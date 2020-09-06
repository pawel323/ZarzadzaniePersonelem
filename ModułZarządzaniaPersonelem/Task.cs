using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace ModułZarządzaniaPersonelem
{
    class Task
    {

        private string nameTask;

        private string description;

        private int task_ID;

        public int Task_ID { get => task_ID; }

        public string NameTask
        {
            get
            {
                return nameTask;
            }
            set
            {
                if (value != null && value is String)
                {
                    nameTask = value;
                }
                else
                {
                    MessageBox.Show("Uzupełnij nazwę zadania");
                    return;
                }
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value != null && value is String)
                {
                    description = value;
                }
                else
                {
                    MessageBox.Show("Uzupełnij opis");
                    return;

                }
            }
        }
      
        //Sprawdzenie parametrów wstawianych do bazy danych
        public void ADDTASK(string nameTask, string description)
        {

            string a = nameTask;
            string b = description;
            Regex rex = new Regex("^[a-z0-9ęóąśłżźćń ]+$", RegexOptions.IgnoreCase);
            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Task t = new Task();
            if (a != b && a != null && b != null && result1 == true && result2 == true)
            {
                t.NameTask = a;
                t.Description = b;
                AddTask(t.NameTask, t.Description);
            }
            else
            {
                MessageBox.Show("Niepoprawne znaki w formularzu");
            }
        }

        //Sprawdzenie parametrów modyfikowanych w bazie danych
        public void UPDATE(string nameTask, string description, int id)
        {
            string a = nameTask;
            string b = description;
            int c = id;
            Regex rex = new Regex("^[a-z0-9ęóąśłżźćń ]+$", RegexOptions.IgnoreCase);
            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Task t = new Task();
            if (a != b && a != null && b != null && c > 0 && result1 == true && result2 == true)
            {
                t.NameTask = a;
                t.Description = b;
               
                UpdateTask(t.nameTask, t.description, c);
            }
            else
            {
                MessageBox.Show("Niepoprawne znaki w formularzu");
            }
        }

        //Dodanie nowego zadania do bazy danych
        void AddTask(string nameTask, string description)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                try
                {
                    string query = "if (not exists(select * from [Task] where nameTask = @nameTask AND description = @description)) " +
                         "begin insert into [Task] (nameTask, description) values(@nameTask, @description) PRINT 'Dodano nowe zadanie' END ELSE PRINT 'Podane zadanie już istnieje'";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nameTask", nameTask);
                        cmd.Parameters.AddWithValue("@description", description);
                        con.Open();
                        con.InfoMessage += respondeMessage;
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Niepowodzenie " + e.ToString());
                }
            }
        }

        //Zmodyfikowanie zadania z bazy danych
        void UpdateTask(string nameTask, string description, int id)
        {

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                try
                {
                    string query1 = "if (not exists(select * from [Task] where nameTask = @nameTask AND description = @description)) " +
                        "begin update[Task] SET nameTask = @nameTask, " +
                        "description = @description where task_ID= @task_ID PRINT 'Zaktualizowano zadanie' end else" +
                        " PRINT 'Podane zadanie już istnieje'";

                    using (SqlCommand cmd = new SqlCommand(query1, con))
                    {
                        cmd.Parameters.AddWithValue("@nameTask", nameTask);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@task_ID", id);
                        con.Open();
                        con.InfoMessage += respondeMessage;
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Niepowodzenie");
                }
            }
        }

        //Wyświetlanie komunikatów z bazy danych
        void respondeMessage(object sender, SqlInfoMessageEventArgs e)
        {
            var outputFromQuery = e.Message;
            MessageBox.Show(outputFromQuery.ToString());
        }

        public override string ToString()
        {
            return description;
        }
    }
}
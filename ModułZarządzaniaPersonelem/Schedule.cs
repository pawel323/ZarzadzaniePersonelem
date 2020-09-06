using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;


namespace ModułZarządzaniaPersonelem
{
    class Schedule
    {
        int schedule_ID, user_ID;
        string task_ID, scheduleStatus_ID;

        DateTime dateSchedule;

        TimeSpan hourOfExecution;

        public int Schedule_ID { get => schedule_ID; }

        public int User_ID
        {
            get
            {
                return user_ID;
            }
            set
            {
                if (value > 0)
                {
                    user_ID = value;
                }
                else
                {
                    MessageBox.Show("Wybierz użytkownika");
                    return;
                }
            }
        }

        public string Task_ID
        {
            get
            {
                return task_ID;
            }
            set
            {
                if (value != null && value is String)
                {
                    task_ID = value;
                }
                else
                {
                    MessageBox.Show("Wybierz zadanie");
                    return;
                }
            }
        }

        public string ScheduleStatus_ID
        {
            get
            {
                return scheduleStatus_ID;
            }
            set
            {
                if (value != null && value is String)
                {
                    scheduleStatus_ID = value;
                }
                else
                {
                    MessageBox.Show("Przypisz status zadania");
                    return;
                }
            }
        }

        public DateTime DateSchedule { get => dateSchedule; set => dateSchedule = value; }

        public TimeSpan HourOfExecution { get => hourOfExecution; set => hourOfExecution = value; }

        public object[] ToObjTbl { get => new object[] { Task_ID, ScheduleStatus_ID, HourOfExecution }; }

        //Sprawdzenie parametrów wstawianych do bazy danych
        public void ASSIGNTASK(string imie, string nazwisko, string opis, string dataTerminarza, string nazwaStatusu, string godzina, string minuta)
        {
            var a = imie;
            var b = nazwisko;
            var c = opis;
            var d = dataTerminarza;
            var e = nazwaStatusu;
            var f = godzina;
            var g = minuta;
            Regex rex = new Regex("^[a-z0-9ęóąśłżźćń ]+$", RegexOptions.IgnoreCase);
            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(c);
            Boolean result4 = rex.IsMatch(e);
            Boolean result5 = rex.IsMatch(f);
            Boolean result6 = rex.IsMatch(g);

            if (a!=null && b!=null && c!=null && e!=null && f!=null && g != null && result1 == true && result2 == true && result3 == true && result4 == true && result5 == true && result6 == true)
            {
                AssignTask(a,b,c,d,e,f,g);
            }
            else
            {
                MessageBox.Show("Niepoprawne znaki w formularzu");
            }
        }

        //Dodanie nowego zadania do bazy danych
        void AssignTask(string imie, string nazwisko, string opis, string dataTerminarza, string nazwaStatusu, string godzina, string minuta)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                try
                {
                    string query = " set dateformat dmy if(not exists (select * from Schedule where " +
                        "user_ID = (select user_ID from[User] where firstName = @firstName " +
                        "AND lastName = @lastName) AND dateSchedule = @dateSchedule " +
                        "AND task_ID = (select task_ID from Task where description = @description) " +
                        "AND scheduleStatus_ID = (select scheduleStatus_ID " +
                        "from ScheduleStatus where nameStatus = @nameStatus) " +
                        "AND hourOfExecution = @hourOfExecution)) begin insert into Schedule(user_ID, task_ID, " +
                        "dateSchedule, scheduleStatus_ID, hourOfExecution) values((select user_ID from[User] " +
                        "where firstName = @firstName AND lastName = @lastName),(select task_ID from Task " +
                        "where description = @description),@dateSchedule,(select scheduleStatus_ID from " +
                        "ScheduleStatus where nameStatus = @nameStatus), @hourOfExecution) " +
                        "PRINT 'Przydzielono zadanie' end else PRINT 'Zadanie zostało już wcześniej przydzielone'";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@firstName", imie);
                        cmd.Parameters.AddWithValue("@lastName", nazwisko);
                        cmd.Parameters.AddWithValue("@description", opis);
                        cmd.Parameters.AddWithValue("@dateSchedule", dataTerminarza);
                        cmd.Parameters.AddWithValue("@nameStatus", nazwaStatusu);

                        string hr = godzina;
                        string min = minuta;
                        string time = hr + ":" + min;
                        cmd.Parameters.Add("@hourOfExecution",System.Data.SqlDbType.Time).Value = TimeSpan.Parse(time);
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

        //Wyświetlanie komunikatów z bazy danych
        void respondeMessage(object sender, SqlInfoMessageEventArgs e)
        {
            var outputFromQuery = e.Message;
            MessageBox.Show(outputFromQuery.ToString());
        }

        //Sprawdzenie parametrów modyfikowanych w bazie danych
        public void UPDATETASK(string nowyStatus, string id)
        {
            var a = nowyStatus;
            var b = id;
            Regex rex = new Regex("^[a-z0-9ęóąśłżźćń ]+$", RegexOptions.IgnoreCase);
            Boolean result1 = rex.IsMatch(a);
            if (a != null && result1 == true)
                UpdateTask(a,b);
            else
            {
                MessageBox.Show("Niepoprawne znaki w formularzu");
            }
        }

        //Zmodyfikowanie statusu przypisanego zadania
        void UpdateTask(string nowyStatus, string id)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                try
                {
                    string query = "update Schedule SET scheduleStatus_ID = (select scheduleStatus_ID from ScheduleStatus where nameStatus = @nameStatus) where schedule_ID = @schedule_ID PRINT 'Zaktualizowano'";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nameStatus", nowyStatus);
                        cmd.Parameters.AddWithValue("@schedule_ID", id);
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
    }
}
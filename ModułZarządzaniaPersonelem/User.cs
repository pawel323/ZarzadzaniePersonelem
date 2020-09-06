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
    class User
    {
        int user_ID;

        string firstName;

        string lastName;

        string login;

        string passwordHash;

        string codeHash;

        decimal baseSalary;

        decimal hourlyRate;

        string permission;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value != null && value is String)
                {
                    firstName = value;
                }
                else
                {
                    MessageBox.Show("Uzupełnij imię");
                    return;
                }
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value != null && value is String)
                {
                    lastName = value;
                }
                else
                {
                    MessageBox.Show("Uzupełnij nazwisko");
                    return;
                }
            }
        }

        public decimal BaseSalary
        {
            get
            {
                return baseSalary;
            }
            set
            {
                if (value > 0.00M)
                {
                    baseSalary = value;
                }
                else
                {
                    MessageBox.Show("Uzupełnij pensję");
                    return;
                }
            }


        }

        public decimal HourlyRate
        {
            get
            {
                return hourlyRate;
            }
            set
            {
                if (value > 0.00M)
                {
                    hourlyRate = value;
                }
                else
                {
                    MessageBox.Show("Uzupełnij stawkę godzinową");
                    return;
                }
            }
        }

        public string Permission
        {
            get
            {
                return permission;
            }
            set
            {
                if (value != null && value is String)
                {
                    permission = value;
                }
                else
                {
                    MessageBox.Show("Przypisz uprawnienia");
                    return;
                }
            }
        }

        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                if (value != null)
                {
                    login = value;
                }
                else
                {
                    MessageBox.Show("Uzupełnij login");
                    return;
                }
            }
        }

        public string PasswordHash
        {
            get
            {
                return passwordHash;
            }
            set
            {
                if (value != null)
                {
                    passwordHash = value;
                }
                else
                {
                    MessageBox.Show("Uzupełnij hasło");
                    return;
                }
            }
        }
        public string CodeHash
        {
            get
            {
                return codeHash;
            }
            set
            {
                if (value != null)
                {
                    codeHash = value;
                }
                else
                {
                    MessageBox.Show("Uzupełnij kod");
                    return;
                }
            }
        }
        public int User_Id { get => user_ID; set => user_ID = value; }

        public object[] ObjTbl { get => new object[] { FirstName, LastName, Login, PasswordHash, CodeHash, BaseSalary, HourlyRate, Permission }; }

        public object[] ObjTbl2 { get => new object[] { FirstName, LastName }; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        //Sprawdzenie parametrów wstawiwanych do bazy danych
        public void INSERTUSER(string firstName, string lastName, string login, string passwordHash, string codeHash, decimal baseSalary, decimal hourlyRate, string permission)
        {
            var a = firstName;
            var b = lastName;
            var c = login;
            var d = passwordHash;
            var e = codeHash;
            var f = baseSalary;
            var g = hourlyRate;
            var h = permission;
            Regex rex = new Regex("^[a-zęóąśłżźćń ]+$", RegexOptions.IgnoreCase);
            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);
            Regex rex2 = new Regex("^[a-z0-9ęóąśłżźćń ]+$", RegexOptions.IgnoreCase);
            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);
            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && h != null && d.Length > 6
                && result1 == true && result2 == true && result3 == true && result4 == true && result5 == true && result6 == true)
            {
                u.FirstName = a;
                u.LastName = b;
                u.Login = c;
                u.PasswordHash = d;
                u.CodeHash = e;
                u.BaseSalary = f;
                u.HourlyRate = g;
                u.Permission = h;
              
                InsertUser(u.FirstName, u.LastName, u.Login, u.PasswordHash, u.CodeHash, u.BaseSalary, u.HourlyRate, u.Permission);
            }
            else
            {
                MessageBox.Show("Niepoprawne znaki w formularzu");
            }
        }

        //Sprawdzenie parametrów usuwanych z bazy danych
        public void DELETEUSER(string firstName, string lastName, string login, string passwordHash, string codeHash, decimal baseSalary, decimal hourlyRate, string permission,int id)
        {

            var a = firstName;
            var b = lastName;
            var c = login;
            var d = passwordHash;
            var e = codeHash;
            var f = baseSalary;
            var g = hourlyRate;
            var h = permission;
            Regex rex = new Regex("^[a-zęóąśłżźćń ]+$", RegexOptions.IgnoreCase);
            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);
            Regex rex2 = new Regex("^[a-z0-9ęóąśłżźćń ]+$", RegexOptions.IgnoreCase);
            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);

            if (a != null && b != null && c != null && d != null && e != null && result1 == true && result2 == true && result3 == true
                && result4 == true && result5 == true && result6 == true)
            {
           
                DeleteUser(id);

            }
            else
            {
                MessageBox.Show("Niepoprawne znaki w formularzu");
            }
        }

        //Wstawienie pracownika do bazy danych
        void InsertUser(string firstName, string lastName, string login, string passwordHash, string codeHash, decimal baseSalary, decimal hourlyRate, string permission)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                try
                {
                    string query = "if (not exists(select * from [User] where firstName = @firstName AND lastName = @lastName " +
                         "AND login = @login AND passwordHash = @passwordHash AND codeHash = @codeHash AND baseSalary = @baseSalary " +
                         "AND hourlyRate = @hourlyRate AND permission = @permission)) " +
                         "begin insert into [User] (firstName,lastName,login,passwordHash,codeHash,baseSalary,hourlyRate,permission)" +
                         "values" +
                        "(@firstName, @lastName, @login, @passwordHash, @codeHash, @baseSalary, @hourlyRate, @permission) " +
                        "PRINT 'Dodano pracownika'end else PRINT 'Podany pracownik już istnieje'";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@passwordHash", passwordHash);
                        cmd.Parameters.AddWithValue("@codeHash", codeHash);
                        cmd.Parameters.AddWithValue("@baseSalary", baseSalary);
                        cmd.Parameters.AddWithValue("@hourlyRate", hourlyRate);
                        cmd.Parameters.AddWithValue("@permission", Convert.ToString(permission));
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

        //Usunięcie pracownika z bazy danych
        void DeleteUser(int id)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                try
                {
                    string q = "if (exists(select * from [User] where user_ID = @user_ID)) begin delete " +
                        "from [User] where user_ID = @user_ID Print 'Usunięto' end else print 'Nie ma takiego pracownika'";

                    using (SqlCommand cmd = new SqlCommand(q, con))
                    {
                     
                        cmd.Parameters.AddWithValue("@user_ID", id);
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
        
        //Sprawdzanie modyfikowanych parametrów
        public void UPDATEUSER(User user)
        {
            var a = user.FirstName;
            var b = user.LastName;
            var c = user.Login;
            var d = user.PasswordHash;
            var e = user.CodeHash;
            var f = user.BaseSalary;
            var g = user.HourlyRate;
            var h = user.Permission;
            Regex rex = new Regex("^[a-zęóąśłżźćń]+$", RegexOptions.IgnoreCase);
            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);
            Regex rex2 = new Regex("^[a-z0-9ęóąśłżźćń ]+$", RegexOptions.IgnoreCase);
            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);
            if (user.FirstName != null && user.LastName != null && user.Login != null && user.PasswordHash != null && user.CodeHash != null && user.BaseSalary >0 
                && user.HourlyRate >0 && user.Permission != null && result1 == true && result2 == true && result3 == true && result4 == true && result5 == true && result6 == true)
            {
                UpdateUser(user);
            }
            else
            {
                MessageBox.Show("Niepoprawne znaki w formularzu");
            }
        }

        //Modyfikacja informacji o pracowniku w bazie danych
        public void UpdateUser(User user)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {

                try
                {
                    string query1 = "if (not exists(select * from [User] where firstName = @firstName AND lastName = @lastName " +
                        "AND login = @login AND passwordHash = @passwordHash AND codeHash = @codeHash AND baseSalary = @baseSalary " +
                        "AND hourlyRate = @hourlyRate AND permission = @permission)) begin update[User] SET firstName = @firstName, " +
                        "lastName = @lastName, login = @login, passwordHash = @passwordHash, codeHash = @codeHash, baseSalary = @baseSalary," +
                        " hourlyRate = @hourlyRate, permission = @permission where user_ID= @user_ID PRINT 'Zaktualizowano informacje' end else" +
                        " PRINT 'Podany pracownik już istnieje'";

                    using (SqlCommand cmd = new SqlCommand(query1, con))
                    {
                        cmd.Parameters.AddWithValue("@firstName", user.FirstName);
                        cmd.Parameters.AddWithValue("@lastName", user.LastName);
                        cmd.Parameters.AddWithValue("@login", user.Login);
                        cmd.Parameters.AddWithValue("@passwordHash", user.PasswordHash);
                        cmd.Parameters.AddWithValue("@codeHash", user.CodeHash);
                        cmd.Parameters.AddWithValue("@baseSalary", user.BaseSalary);
                        cmd.Parameters.AddWithValue("@hourlyRate", user.HourlyRate);
                        cmd.Parameters.AddWithValue("@permission", user.Permission);
                        cmd.Parameters.AddWithValue("@user_ID", user.User_Id);
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
    }
}
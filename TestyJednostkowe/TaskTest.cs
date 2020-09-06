using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modu³Zarz¹dzaniaPersonelem;
using System;
using System.Text.RegularExpressions;

namespace TestyJednostkowe
{
    [TestClass]
    public class Task
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
                if (value != null && value is string)
                {
                    nameTask = value;
                }
                else
                {
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
                if (value != null && value is string)
                {
                    description = value;
                }
                else
                {
                    return;
                }
            }
        }

        [TestMethod]
        public void ADDTASK()
        {
            string a = "Obs³uga kasy";
            string b = "Sprzeda¿ biletów";

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);

            Task t = new Task();
            if (a != b && a != null && b != null && result1 == true && result2 == true)
            {
                t.NameTask = a;
                t.Description = b;
            }
            Assert.IsNotNull(t.NameTask, "Uzupe³nij nazwê zadania");
            Assert.IsNotNull(t.Description, "Uzupe³nij opis zadania");
        }

        [TestMethod]
        public void ADDTASK2()
        {
            string a = "Sprz¹tanie sali";
            string b = null;

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Task t = new Task();

            if (a != b && a != null && b != null)
            {
                t.NameTask = a;
                t.Description = b;
            }
            Assert.IsNull(t.NameTask, "Uzupe³nij nazwê zadania");
            Assert.IsNull(t.Description, "Uzupe³nij opis zadania");
        }

        [TestMethod]
        public void ADDTASK3()
        {
            string a = null;
            string b = "Sprzeda¿ biletów";

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Task t = new Task();

            if (a != b && a != null && b != null)
            {
                t.NameTask = a;
                t.Description = b;
            }
            Assert.IsNull(t.NameTask, "Uzupe³nij nazwê zadania");
            Assert.IsNull(t.Description, "Uzupe³nij opis zadania");
        }

        [TestMethod]
        public void ADDTASK4()
        {
            string a = "#$%";
            string b = "Sprzeda¿ biletów";

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);

            Task t = new Task();
            if (a != b && a != null && b != null && result1 == true && result2 == true)
            {
                t.NameTask = a;
                t.Description = b;
            }
            Assert.IsTrue(result1 == false);
            Assert.IsTrue(result2 == true);
        }

        [TestMethod]
        public void ADDTASK5()
        {
            string a = "Obs³uga kasy";
            string b = "*&^*(";

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);

            Task t = new Task();
            if (a != b && a != null && b != null && result1 == true && result2 == true)
            {
                t.NameTask = a;
                t.Description = b;
            }
            Assert.IsTrue(result1 == true);
            Assert.IsTrue(result2 == false);
        }

        [TestMethod]
        public void UPDATETASK()
        {
            string a = "Obs³uga sklepu";
            string b = "Sprzeda¿ przek¹sek";
            int c = 1;

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);

            Task t = new Task();
            if (a != b && a != null && b != null && c > 0 && result1 == true && result2 == true)
            {
                t.NameTask = a;
                t.Description = b;
            }
            Assert.IsNotNull(t.NameTask, "Uzupe³nij nazwê zadania");
            Assert.IsNotNull(t.Description, "Uzupe³nij opis zadania");
        }

        [TestMethod]
        public void UPDATETASK2()
        {
            string a = null;
            string b = "Sprzeda¿ przek¹sek";
            int c = 1;

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Task t = new Task();
            if (a != b && a != null && b != null && c > 0)
            {
                t.NameTask = a;
                t.Description = b;
            }
            Assert.IsNull(t.NameTask, "Uzupe³nij nazwê zadania");
            Assert.IsNull(t.Description, "Uzupe³nij opis zadania");
        }

        [TestMethod]
        public void UPDATETASK3()
        {
            string a = "Obs³uga sklepu";
            string b = null;
            int c = 1;

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Task t = new Task();
            if (a != b && a != null && b != null && c > 0)
            {
                t.NameTask = a;
                t.Description = b;
            }
            Assert.IsNull(t.NameTask, "Uzupe³nij nazwê zadania");
            Assert.IsNull(t.Description, "Uzupe³nij opis zadania");
        }

        [TestMethod]
        public void UPDATETASK4()
        {
            string a = "^(*^";
            string b = "Sprzeda¿ przek¹sek";
            int c = 1;

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);

            Task t = new Task();
            if (a != b && a != null && b != null && c > 0 && result1 == true && result2 == true)
            {
                t.NameTask = a;
                t.Description = b;
            }
            Assert.IsTrue(result1 == false);
            Assert.IsTrue(result2 == true);

        }

        [TestMethod]
        public void UPDATETASK5()
        {
            string a = "Obs³uga sklepu";
            string b = "(&%^$^&&";
            int c = 1;

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);

            Task t = new Task();
            if (a != b && a != null && b != null && c > 0 && result1 == true && result2 == true)
            {
                t.NameTask = a;
                t.Description = b;
            }
            Assert.IsTrue(result1 == true);
            Assert.IsTrue(result2 == false);

        }

    }

    [TestClass]
    public class Schedule
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

                    return;
                }
            }
        }

        public DateTime DateSchedule { get => dateSchedule; set => dateSchedule = value; }

        public TimeSpan HourOfExecution { get => hourOfExecution; set => hourOfExecution = value; }

        public object[] ToObjTbl { get => new object[] { Task_ID, ScheduleStatus_ID, HourOfExecution }; }


        [TestMethod]
        public void UPDATESTATUS()
        {
            var a = "otwarte";
            var b = "zamkniête";
            string aa;
            string bb;

            Regex rex = new Regex("^[a-z0-99êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);

            Schedule sch = new Schedule();
            if (a != null && result1 == true)
            {
                aa = a;
                bb = b;
                Assert.IsNotNull(aa, "Uzupe³nij status zadania");
                Assert.IsNotNull(bb, "Uzupe³nij status zadania");
            }
        }

        [TestMethod]
        public void UPDATESTATUS2()
        {
            string a = null;
            var b = "zamkniête";
            string aa;
            string bb;

            Regex rex = new Regex("^[a-z0-99êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Schedule sch = new Schedule();
            if (a != null)
            {
                aa = a;
                bb = b;
                Assert.IsNotNull(aa, "Uzupe³nij status zadania");
                Assert.IsNotNull(bb, "Uzupe³nij status zadania");
            }
        }

        [TestMethod]
        public void UPDATESTATUS3()
        {
            var a = "otwarte";
            string b = null;
            string aa;
            string bb;

            Regex rex = new Regex("^[a-z0-99êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Schedule sch = new Schedule();
            if (b != null)
            {
                aa = a;
                bb = b;
                Assert.IsNotNull(aa, "Uzupe³nij status zadania");
                Assert.IsNotNull(bb, "Uzupe³nij status zadania");
            }

        }

        [TestMethod]
        public void UPDATESTATUS4()
        {
            var a = "$&%%*^";
            var b = "zamkniête";
            string aa;
            string bb;

            Regex rex = new Regex("^[a-z0-99êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);

            Schedule sch = new Schedule();
            if (a != null && result1 == true && result2 == true)
            {
                aa = a;
                bb = b;

            }
            Assert.IsTrue(result1 == false);
            Assert.IsTrue(result2 == true);
        }

        [TestMethod]
        public void UPDATESTATUS5()
        {
            var a = "Otwarte";
            var b = ")(*^%&";
            string aa;
            string bb;

            Regex rex = new Regex("^[a-z0-99êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);

            Schedule sch = new Schedule();
            if (a != null && result1 == true && result2 == true)
            {
                aa = a;
                bb = b;

            }
            Assert.IsTrue(result1 == true);
            Assert.IsTrue(result2 == false);
        }

        [TestMethod]
        public void ASSIGNTASK()
        {
            var a = "Jan";
            string aa;
            var b = "Kowalski";
            string bb;
            var c = "Sprzeda¿ biletów";
            string cc;
            var d = "10-10-2020";
            string dd;
            var e = "Otwarte";
            string ee;
            var f = "10";
            string ff;
            var g = "30";
            string gg;

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(c);
            Boolean result4 = rex.IsMatch(e);
            Boolean result5 = rex.IsMatch(f);
            Boolean result6 = rex.IsMatch(g);

            if (a != null && b != null && c != null && e != null && f != null && g != null && result1 == true && result2 == true && result3 == true && result4 == true && result5 == true && result6 == true)
            {
                aa = a;
                bb = b;
                cc = c;
                dd = d;
                ee = e;
                ff = f;
                gg = g;

                Assert.IsNotNull(aa, "Uzupe³nij imiê");
                Assert.IsNotNull(bb, "Uzupe³nij nazwisko");
                Assert.IsNotNull(cc, "Uzupe³nij opis zadania");
                Assert.IsNotNull(dd, "Uzupe³nij datê");
                Assert.IsNotNull(ee, "Uzupe³nij status zadania");
                Assert.IsNotNull(ff, "Uzupe³nij godzinê");
                Assert.IsNotNull(gg, "Uzupe³nij minuty");
            }

        }

        [TestMethod]
        public void ASSIGNTASK2()
        {
            string a = null;
            string aa;
            var b = "Kowalski";
            string bb;
            var c = "Sprzeda¿ biletów";
            string cc;
            var d = "10-10-2020";
            string dd;
            var e = "Otwarte";
            string ee;
            var f = "10";
            string ff;
            var g = "30";
            string gg;

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(c);
            Boolean result4 = rex.IsMatch(e);
            Boolean result5 = rex.IsMatch(f);
            Boolean result6 = rex.IsMatch(g);

            if (a != null && b != null && c != null && e != null && f != null && g != null && result2 == true && result3 == true && result4 == true && result5 == true && result6 == true)
            {
                aa = a;
                bb = b;
                cc = c;
                dd = d;
                ee = e;
                ff = f;
                gg = g;

                Assert.IsNotNull(aa, "Uzupe³nij imiê");
                Assert.IsNotNull(bb, "Uzupe³nij nazwisko");
                Assert.IsNotNull(cc, "Uzupe³nij opis zadania");
                Assert.IsNotNull(dd, "Uzupe³nij datê");
                Assert.IsNotNull(ee, "Uzupe³nij status zadania");
                Assert.IsNotNull(ff, "Uzupe³nij godzinê");
                Assert.IsNotNull(gg, "Uzupe³nij minuty");
            }

        }

        [TestMethod]
        public void ASSIGNTASK3()
        {
            var a = "Jan";
            string aa;
            string b = null;
            string bb;
            var c = "Sprzeda¿ biletów";
            string cc;
            var d = "10-10-2020";
            string dd;
            var e = "Otwarte";
            string ee;
            var f = "10";
            string ff;
            var g = "30";
            string gg;

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result3 = rex.IsMatch(c);
            Boolean result4 = rex.IsMatch(e);
            Boolean result5 = rex.IsMatch(f);
            Boolean result6 = rex.IsMatch(g);

            if (a != null && b != null && c != null && e != null && f != null && g != null && result1 == true && result3 == true && result4 == true && result5 == true && result6 == true)
            {
                aa = a;
                bb = b;
                cc = c;
                dd = d;
                ee = e;
                ff = f;
                gg = g;

                Assert.IsNotNull(aa, "Uzupe³nij imiê");
                Assert.IsNotNull(bb, "Uzupe³nij nazwisko");
                Assert.IsNotNull(cc, "Uzupe³nij opis zadania");
                Assert.IsNotNull(dd, "Uzupe³nij datê");
                Assert.IsNotNull(ee, "Uzupe³nij status zadania");
                Assert.IsNotNull(ff, "Uzupe³nij godzinê");
                Assert.IsNotNull(gg, "Uzupe³nij minuty");
            }

        }

        [TestMethod]
        public void ASSIGNTASK4()
        {
            var a = "Jan";
            string aa;
            var b = "Kowalski";
            string bb;
            string c = null;
            string cc;
            var d = "10-10-2020";
            string dd;
            var e = "Otwarte";
            string ee;
            var f = "10";
            string ff;
            var g = "30";
            string gg;

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result4 = rex.IsMatch(e);
            Boolean result5 = rex.IsMatch(f);
            Boolean result6 = rex.IsMatch(g);

            if (a != null && b != null && c != null && e != null && f != null && g != null && result1 == true && result2 == true && result4 == true && result5 == true && result6 == true)
            {
                aa = a;
                bb = b;
                cc = c;
                dd = d;
                ee = e;
                ff = f;
                gg = g;

                Assert.IsNotNull(aa, "Uzupe³nij imiê");
                Assert.IsNotNull(bb, "Uzupe³nij nazwisko");
                Assert.IsNotNull(cc, "Uzupe³nij opis zadania");
                Assert.IsNotNull(dd, "Uzupe³nij datê");
                Assert.IsNotNull(ee, "Uzupe³nij status zadania");
                Assert.IsNotNull(ff, "Uzupe³nij godzinê");
                Assert.IsNotNull(gg, "Uzupe³nij minuty");
            }

        }

        [TestMethod]
        public void ASSIGNTASK5()
        {
            var a = "Jan";
            string aa;
            var b = "Kowalski";
            string bb;
            var c = "Sprzeda¿ biletów";
            string cc;
            string d = null;
            string dd;
            var e = "Otwarte";
            string ee;
            var f = "10";
            string ff;
            var g = "30";
            string gg;

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(c);
            Boolean result4 = rex.IsMatch(e);
            Boolean result5 = rex.IsMatch(f);
            Boolean result6 = rex.IsMatch(g);

            if (a != null && b != null && c != null && e != null && f != null && g != null && result1 == true && result2 == true && result3 == true && result4 == true && result5 == true && result6 == true)
            {
                aa = a;
                bb = b;
                cc = c;
                dd = d;
                ee = e;
                ff = f;
                gg = g;

                Assert.IsNotNull(aa, "Uzupe³nij imiê");
                Assert.IsNotNull(bb, "Uzupe³nij nazwisko");
                Assert.IsNotNull(cc, "Uzupe³nij opis zadania");
                Assert.IsNull(dd, "Uzupe³nij datê");
                Assert.IsNotNull(ee, "Uzupe³nij status zadania");
                Assert.IsNotNull(ff, "Uzupe³nij godzinê");
                Assert.IsNotNull(gg, "Uzupe³nij minuty");
            }

        }

        [TestMethod]
        public void ASSIGNTASK6()
        {
            var a = "Jan";
            string aa;
            var b = "Kowalski";
            string bb;
            var c = "Sprzeda¿ biletów";
            string cc;
            var d = "10-10-2020";
            string dd;
            string e = null;
            string ee;
            var f = "10";
            string ff;
            var g = "30";
            string gg;

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(c);
            Boolean result5 = rex.IsMatch(f);
            Boolean result6 = rex.IsMatch(g);

            if (a != null && b != null && c != null && e != null && f != null && g != null && result1 == true && result2 == true && result3 == true && result5 == true && result6 == true)
            {
                aa = a;
                bb = b;
                cc = c;
                dd = d;
                ee = e;
                ff = f;
                gg = g;

                Assert.IsNotNull(aa, "Uzupe³nij imiê");
                Assert.IsNotNull(bb, "Uzupe³nij nazwisko");
                Assert.IsNotNull(cc, "Uzupe³nij opis zadania");
                Assert.IsNotNull(dd, "Uzupe³nij datê");
                Assert.IsNotNull(ee, "Uzupe³nij status zadania");
                Assert.IsNotNull(ff, "Uzupe³nij godzinê");
                Assert.IsNotNull(gg, "Uzupe³nij minuty");
            }

        }

        [TestMethod]
        public void ASSIGNTASK7()
        {
            var a = "Jan";
            string aa;
            var b = "Kowalski";
            string bb;
            var c = "Sprzeda¿ biletów";
            string cc;
            var d = "10-10-2020";
            string dd;
            var e = "Otwarte";
            string ee;
            string f = null;
            string ff;
            var g = "30";
            string gg;

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(c);
            Boolean result4 = rex.IsMatch(e);
            Boolean result6 = rex.IsMatch(g);

            if (a != null && b != null && c != null && e != null && f != null && g != null && result1 == true && result2 == true && result3 == true && result4 == true && result6 == true)
            {
                aa = a;
                bb = b;
                cc = c;
                dd = d;
                ee = e;
                ff = f;
                gg = g;

                Assert.IsNotNull(aa, "Uzupe³nij imiê");
                Assert.IsNotNull(bb, "Uzupe³nij nazwisko");
                Assert.IsNotNull(cc, "Uzupe³nij opis zadania");
                Assert.IsNotNull(dd, "Uzupe³nij datê");
                Assert.IsNotNull(ee, "Uzupe³nij status zadania");
                Assert.IsNotNull(ff, "Uzupe³nij godzinê");
                Assert.IsNotNull(gg, "Uzupe³nij minuty");
            }

        }

        [TestMethod]
        public void ASSIGNTASK8()
        {
            var a = "Jan";
            string aa;
            var b = "Kowalski";
            string bb;
            var c = "Sprzeda¿ biletów";
            string cc;
            var d = "10-10-2020";
            string dd;
            var e = "Otwarte";
            string ee;
            var f = "10";
            string ff;
            string g = null;
            string gg;

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(c);
            Boolean result4 = rex.IsMatch(e);
            Boolean result5 = rex.IsMatch(f);

            if (a != null && b != null && c != null && e != null && f != null && g != null && result1 == true && result2 == true && result3 == true && result4 == true && result5 == true)
            {
                aa = a;
                bb = b;
                cc = c;
                dd = d;
                ee = e;
                ff = f;
                gg = g;

                Assert.IsNotNull(aa, "Uzupe³nij imiê");
                Assert.IsNotNull(bb, "Uzupe³nij nazwisko");
                Assert.IsNotNull(cc, "Uzupe³nij opis zadania");
                Assert.IsNotNull(dd, "Uzupe³nij datê");
                Assert.IsNotNull(ee, "Uzupe³nij status zadania");
                Assert.IsNotNull(ff, "Uzupe³nij godzinê");
                Assert.IsNotNull(gg, "Uzupe³nij minuty");
            }

        }

        [TestMethod]
        public void ASSIGNTASK9()
        {
            var a = "$##$%%";
            string aa;
            var b = "Kowalski";
            string bb;
            var c = "Sprzeda¿ biletów";
            string cc;
            var d = "10-10-2020";
            string dd;
            var e = "Otwarte";
            string ee;
            var f = "10";
            string ff;
            var g = "30";
            string gg;

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(c);
            Boolean result4 = rex.IsMatch(e);
            Boolean result5 = rex.IsMatch(f);
            Boolean result6 = rex.IsMatch(g);

            if (a != null && b != null && c != null && e != null && f != null && g != null && result1 == true && result2 == true && result3 == true && result4 == true && result5 == true && result6 == true)
            {
                aa = a;
                bb = b;
                cc = c;
                dd = d;
                ee = e;
                ff = f;
                gg = g;

                Assert.IsTrue(result1 == false);
                Assert.IsTrue(result2 == true);
                Assert.IsTrue(result3 == true);
                Assert.IsTrue(result4 == true);
                Assert.IsTrue(result5 == true);
                Assert.IsTrue(result6 == true);

            }

        }

        [TestMethod]
        public void ASSIGNTASK10()
        {
            var a = "Jan";
            string aa;
            var b = "(&%$%$";
            string bb;
            var c = "Sprzeda¿ biletów";
            string cc;
            var d = "10-10-2020";
            string dd;
            var e = "Otwarte";
            string ee;
            var f = "10";
            string ff;
            var g = "30";
            string gg;

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(c);
            Boolean result4 = rex.IsMatch(e);
            Boolean result5 = rex.IsMatch(f);
            Boolean result6 = rex.IsMatch(g);

            if (a != null && b != null && c != null && e != null && f != null && g != null && result1 == true && result2 == true && result3 == true && result4 == true && result5 == true && result6 == true)
            {
                aa = a;
                bb = b;
                cc = c;
                dd = d;
                ee = e;
                ff = f;
                gg = g;

                Assert.IsTrue(result1 == true);
                Assert.IsTrue(result2 == false);
                Assert.IsTrue(result3 == true);
                Assert.IsTrue(result4 == true);
                Assert.IsTrue(result5 == true);
                Assert.IsTrue(result6 == true);

            }

        }

        [TestMethod]
        public void ASSIGNTASK11()
        {
            var a = "Jan";
            string aa;
            var b = "Kowalski";
            string bb;
            var c = "!><?:";
            string cc;
            var d = "10-10-2020";
            string dd;
            var e = "Otwarte";
            string ee;
            var f = "10";
            string ff;
            var g = "30";
            string gg;

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(c);
            Boolean result4 = rex.IsMatch(e);
            Boolean result5 = rex.IsMatch(f);
            Boolean result6 = rex.IsMatch(g);

            if (a != null && b != null && c != null && e != null && f != null && g != null && result1 == true && result2 == true && result3 == true && result4 == true && result5 == true && result6 == true)
            {
                aa = a;
                bb = b;
                cc = c;
                dd = d;
                ee = e;
                ff = f;
                gg = g;

                Assert.IsTrue(result1 == true);
                Assert.IsTrue(result2 == true);
                Assert.IsTrue(result3 == false);
                Assert.IsTrue(result4 == true);
                Assert.IsTrue(result5 == true);
                Assert.IsTrue(result6 == true);

            }

        }

        [TestMethod]
        public void ASSIGNTASK12()
        {
            var a = "Jan";
            string aa;
            var b = "Kowalski";
            string bb;
            var c = "Sprzeda¿ biletów";
            string cc;
            var d = "10-10-2020";
            string dd;
            var e = "(*^&%&&";
            string ee;
            var f = "10";
            string ff;
            var g = "30";
            string gg;

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(c);
            Boolean result4 = rex.IsMatch(e);
            Boolean result5 = rex.IsMatch(f);
            Boolean result6 = rex.IsMatch(g);

            if (a != null && b != null && c != null && e != null && f != null && g != null && result1 == true && result2 == true && result3 == true && result4 == true && result5 == true && result6 == true)
            {
                aa = a;
                bb = b;
                cc = c;
                dd = d;
                ee = e;
                ff = f;
                gg = g;

                Assert.IsTrue(result1 == true);
                Assert.IsTrue(result2 == true);
                Assert.IsTrue(result3 == true);
                Assert.IsTrue(result4 == false);
                Assert.IsTrue(result5 == true);
                Assert.IsTrue(result6 == true);

            }

        }

        [TestMethod]
        public void ASSIGNTASK13()
        {
            var a = "Jan";
            string aa;
            var b = "Kowalski";
            string bb;
            var c = "Sprzeda¿ biletów";
            string cc;
            var d = "10-10-2020";
            string dd;
            var e = "Otwarte";
            string ee;
            var f = "*(^&";
            string ff;
            var g = "30";
            string gg;

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(c);
            Boolean result4 = rex.IsMatch(e);
            Boolean result5 = rex.IsMatch(f);
            Boolean result6 = rex.IsMatch(g);

            if (a != null && b != null && c != null && e != null && f != null && g != null && result1 == true && result2 == true && result3 == true && result4 == true && result5 == true && result6 == true)
            {
                aa = a;
                bb = b;
                cc = c;
                dd = d;
                ee = e;
                ff = f;
                gg = g;

                Assert.IsTrue(result1 == true);
                Assert.IsTrue(result2 == true);
                Assert.IsTrue(result3 == true);
                Assert.IsTrue(result4 == true);
                Assert.IsTrue(result5 == false);
                Assert.IsTrue(result6 == true);

            }

        }

        [TestMethod]
        public void ASSIGNTASK14()
        {
            var a = "Jan";
            string aa;
            var b = "Kowalski";
            string bb;
            var c = "Sprzeda¿ biletów";
            string cc;
            var d = "10-10-2020";
            string dd;
            var e = "Otwarte";
            string ee;
            var f = "10";
            string ff;
            var g = "%&I^&";
            string gg;

            Regex rex = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(c);
            Boolean result4 = rex.IsMatch(e);
            Boolean result5 = rex.IsMatch(f);
            Boolean result6 = rex.IsMatch(g);

            if (a != null && b != null && c != null && e != null && f != null && g != null && result1 == true && result2 == true && result3 == true && result4 == true && result5 == true && result6 == true)
            {
                aa = a;
                bb = b;
                cc = c;
                dd = d;
                ee = e;
                ff = f;
                gg = g;

                Assert.IsTrue(result1 == true);
                Assert.IsTrue(result2 == true);
                Assert.IsTrue(result3 == true);
                Assert.IsTrue(result4 == true);
                Assert.IsTrue(result5 == true);
                Assert.IsTrue(result6 == false);

            }

        }


    }

    [TestClass]
    public class User
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

        [TestMethod]
        public void INSERTUSER()
        {
            var a = "Jan";
            var b = "Kowalski";
            var c = "Jankow";
            var d = "Jan1234";
            var e = "887va4n4432m";
            var f = 3000;
            var g = 17;
            var h = "uprzywilejowany";
            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

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
            }
            Assert.IsNotNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNotNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNotNull(u.login, "Uzupe³nij login");
            Assert.IsNotNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNotNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNotNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void INSERTUSER2()
        {
            string a = null;
            var b = "Kowalski";
            var c = "Jankow";
            var d = "Jan1234";
            var e = "887va4n4432m";
            var f = 3000;
            var g = 17;
            var h = "uprzywilejowany";
            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && h != null && d.Length > 6
                && result2 == true && result3 == true && result4 == true && result5 == true && result6 == true)
            {
                u.FirstName = a;
                u.LastName = b;
                u.Login = c;
                u.PasswordHash = d;
                u.CodeHash = e;
                u.BaseSalary = f;
                u.HourlyRate = g;
                u.Permission = h;
            }
            Assert.IsNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNull(u.login, "Uzupe³nij login");
            Assert.IsNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void INSERTUSER3()
        {
            var a = "Jan";
            string b = null;
            var c = "Jankow";
            var d = "Jan1234";
            var e = "887va4n4432m";
            var f = 3000;
            var g = 17;
            var h = "uprzywilejowany";
            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && h != null && d.Length > 6
                && result1 == true && result3 == true && result4 == true && result5 == true && result6 == true)
            {
                u.FirstName = a;
                u.LastName = b;
                u.Login = c;
                u.PasswordHash = d;
                u.CodeHash = e;
                u.BaseSalary = f;
                u.HourlyRate = g;
                u.Permission = h;
            }
            Assert.IsNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNull(u.login, "Uzupe³nij login");
            Assert.IsNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void INSERTUSER4()
        {
            var a = "Jan";
            var b = "Kowalski";
            string c = null;
            var d = "Jan1234";
            var e = "887va4n4432m";
            var f = 3000;
            var g = 17;
            var h = "uprzywilejowany";
            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && h != null && d.Length > 6
                && result1 == true && result2 == true && result3 == true && result5 == true && result6 == true)
            {
                u.FirstName = a;
                u.LastName = b;
                u.Login = c;
                u.PasswordHash = d;
                u.CodeHash = e;
                u.BaseSalary = f;
                u.HourlyRate = g;
                u.Permission = h;
            }
            Assert.IsNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNull(u.login, "Uzupe³nij login");
            Assert.IsNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void INSERTUSER5()
        {
            var a = "Jan";
            var b = "Kowalski";
            var c = "Jankow";
            string d = null;
            var e = "887va4n4432m";
            var f = 3000;
            var g = 17;
            var h = "uprzywilejowany";
            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && h != null && d.Length > 6
                && result1 == true && result2 == true && result3 == true && result4 == true && result6 == true)
            {
                u.FirstName = a;
                u.LastName = b;
                u.Login = c;
                u.PasswordHash = d;
                u.CodeHash = e;
                u.BaseSalary = f;
                u.HourlyRate = g;
                u.Permission = h;
            }
            Assert.IsNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNull(u.login, "Uzupe³nij login");
            Assert.IsNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNull(u.permission, "Uzupe³nij uprawnienia"); ;
        }

        [TestMethod]
        public void INSERTUSER6()
        {
            var a = "Jan";
            var b = "Kowalski";
            var c = "Jankow";
            var d = "Jan1234";
            string e = null;
            var f = 3000;
            var g = 17;
            var h = "uprzywilejowany";
            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && h != null && d.Length > 6
                && result1 == true && result2 == true && result3 == true && result4 == true && result5 == true)
            {
                u.FirstName = a;
                u.LastName = b;
                u.Login = c;
                u.PasswordHash = d;
                u.CodeHash = e;
                u.BaseSalary = f;
                u.HourlyRate = g;
                u.Permission = h;
            }
            Assert.IsNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNull(u.login, "Uzupe³nij login");
            Assert.IsNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void INSERTUSER7()
        {
            var a = "Jan";
            var b = "Kowalski";
            var c = "Jankow";
            var d = "Jan1234";
            string e = "887va4n4432m";
            var f = 3000;
            var g = 17;
            string h = null;
            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);


            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && h != null && d.Length > 6
                && result1 == true && result2 == true && result4 == true && result5 == true)
            {
                u.FirstName = a;
                u.LastName = b;
                u.Login = c;
                u.PasswordHash = d;
                u.CodeHash = e;
                u.BaseSalary = f;
                u.HourlyRate = g;
                u.Permission = h;
            }
            Assert.IsNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNull(u.login, "Uzupe³nij login");
            Assert.IsNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void INSERTUSER8()
        {
            var a = "Jan";
            var b = "Kowalski";
            var c = "Jankow";
            var d = "Jan1234";
            var e = "887va4n4432m";
            var f = 0;
            var g = 17;
            var h = "uprzywilejowany";
            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);
            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);
            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);
            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && h != null && d.Length > 6 && result1 == true && result2 == true && result3 == true && result4 == true && result5 == true && result6 == false)
            {
                u.FirstName = a;
                u.LastName = b;
                u.Login = c;
                u.PasswordHash = d;
                u.CodeHash = e;
                u.BaseSalary = f;
                u.HourlyRate = g;
                u.Permission = h;
            }
            Assert.IsNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNull(u.login, "Uzupe³nij login");
            Assert.IsNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void INSERTUSER9()
        {
            var a = "Jan";
            var b = "Kowalski";
            var c = "Jankow";
            var d = "Jan1234";
            var e = "887va4n4432m";
            var f = 3000;
            var g = 0;
            var h = "uprzywilejowany";
            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && h != null && d.Length > 6 && result1 == true && result2 == true && result3 == true && result4 == true && result5 == true && result6 == false)
            {
                u.FirstName = a;
                u.LastName = b;
                u.Login = c;
                u.PasswordHash = d;
                u.CodeHash = e;
                u.BaseSalary = f;
                u.HourlyRate = g;
                u.Permission = h;
            }
            Assert.IsNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNull(u.login, "Uzupe³nij login");
            Assert.IsNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void INSERTUSER10()
        {
            var a = "@#$";
            var b = "Kowalski";
            var c = "Jankow";
            var d = "Jan1234";
            var e = "887va4n4432m";
            var f = 3000;
            var g = 17;
            var h = "uprzywilejowany";
            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

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
            }
            Assert.IsTrue(result1 == false);
            Assert.IsTrue(result2 == true);
            Assert.IsTrue(result3 == true);
            Assert.IsTrue(result4 == true);
            Assert.IsTrue(result5 == true);
            Assert.IsTrue(result6 == true);
        }

        [TestMethod]
        public void INSERTUSER11()
        {
            var a = "Jan";
            var b = "{()*&";
            var c = "Jankow";
            var d = "Jan1234";
            var e = "887va4n4432m";
            var f = 3000;
            var g = 17;
            var h = "uprzywilejowany";
            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

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
            }
            Assert.IsTrue(result1 == true);
            Assert.IsTrue(result2 == false);
            Assert.IsTrue(result3 == true);
            Assert.IsTrue(result4 == true);
            Assert.IsTrue(result5 == true);
            Assert.IsTrue(result6 == true);
        }

        [TestMethod]
        public void INSERTUSER12()
        {
            var a = "Jan";
            var b = "Kowalski";
            var c = "Jankow";
            var d = "Jan1234";
            var e = "887va4n4432m";
            var f = 3000;
            var g = 17;
            var h = "&^%$#";
            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

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
            }
            Assert.IsTrue(result1 == true);
            Assert.IsTrue(result2 == true);
            Assert.IsTrue(result3 == false);
            Assert.IsTrue(result4 == true);
            Assert.IsTrue(result5 == true);
            Assert.IsTrue(result6 == true);
        }

        [TestMethod]
        public void INSERTUSER13()
        {
            var a = "Jan";
            var b = "Kowalski";
            var c = "*%*&^(";
            var d = "Jan1234";
            var e = "887va4n4432m";
            var f = 3000;
            var g = 17;
            var h = "uprzywieljowany";
            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

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
            }
            Assert.IsTrue(result1 == true);
            Assert.IsTrue(result2 == true);
            Assert.IsTrue(result3 == true);
            Assert.IsTrue(result4 == false);
            Assert.IsTrue(result5 == true);
            Assert.IsTrue(result6 == true);
        }

        [TestMethod]
        public void INSERTUSER14()
        {
            var a = "Jan";
            var b = "Kowalski";
            var c = "Jankow";
            var d = "(*^(&^";
            var e = "887va4n4432m";
            var f = 3000;
            var g = 17;
            var h = "uprzywieljowany";
            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

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
            }
            Assert.IsTrue(result1 == true);
            Assert.IsTrue(result2 == true);
            Assert.IsTrue(result3 == true);
            Assert.IsTrue(result4 == true);
            Assert.IsTrue(result5 == false);
            Assert.IsTrue(result6 == true);
        }

        [TestMethod]
        public void INSERTUSER15()
        {
            var a = "Jan";
            var b = "Kowalski";
            var c = "Jankow";
            var d = "Jan1234";
            var e = "*%^$^&";
            var f = 3000;
            var g = 17;
            var h = "uprzywieljowany";
            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

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
            }
            Assert.IsTrue(result1 == true);
            Assert.IsTrue(result2 == true);
            Assert.IsTrue(result3 == true);
            Assert.IsTrue(result4 == true);
            Assert.IsTrue(result5 == true);
            Assert.IsTrue(result6 == false);
        }

        [TestMethod]
        public void UPDATEUSER()
        {
            var a = "Adam";
            var b = "Nowakowski";
            var c = "NowaKo";
            var d = "Nowak123";
            var e = "227va546hg";
            var f = 2500;
            var g = 15;
            var h = "nieuprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

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

            }
            Assert.IsNotNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNotNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNotNull(u.login, "Uzupe³nij login");
            Assert.IsNotNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNotNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNotNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void UPDATEUSER2()
        {
            string a = null;
            var b = "Nowakowski";
            var c = "NowaKo";
            var d = "Nowak123";
            var e = "227va546hg";
            var f = 2500;
            var g = 15;
            var h = "nieuprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ]+$", RegexOptions.IgnoreCase);

            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && h != null && d.Length > 6
                && result2 == true && result3 == true && result4 == true && result5 == true && result6 == true)
            {
                u.FirstName = a;
                u.LastName = b;
                u.Login = c;
                u.PasswordHash = d;
                u.CodeHash = e;
                u.BaseSalary = f;
                u.HourlyRate = g;
                u.Permission = h;

            }
            Assert.IsNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNull(u.login, "Uzupe³nij login");
            Assert.IsNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void UPDATEUSER3()
        {
            var a = "Adam";
            string b = null;
            var c = "NowaKo";
            var d = "Nowak123";
            var e = "227va546hg";
            var f = 2500;
            var g = 15;
            var h = "nieuprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && h != null && d.Length > 6
                && result1 == true && result3 == true && result4 == true && result5 == true && result6 == true)
            {
                u.FirstName = a;
                u.LastName = b;
                u.Login = c;
                u.PasswordHash = d;
                u.CodeHash = e;
                u.BaseSalary = f;
                u.HourlyRate = g;
                u.Permission = h;

            }
            Assert.IsNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNull(u.login, "Uzupe³nij login");
            Assert.IsNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void UPDATEUSER4()
        {
            var a = "Adam";
            var b = "Nowakowski";
            string c = null;
            var d = "Nowak123";
            var e = "227va546hg";
            var f = 2500;
            var g = 15;
            var h = "nieuprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && h != null && d.Length > 6
                && result1 == true && result2 == true && result3 == true && result5 == true && result6 == true)
            {
                u.FirstName = a;
                u.LastName = b;
                u.Login = c;
                u.PasswordHash = d;
                u.CodeHash = e;
                u.BaseSalary = f;
                u.HourlyRate = g;
                u.Permission = h;

            }
            Assert.IsNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNull(u.login, "Uzupe³nij login");
            Assert.IsNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void UPDATEUSER5()
        {
            var a = "Adam";
            var b = "Nowakowski";
            var c = "NowaKo";
            string d = null;
            var e = "227va546hg";
            var f = 2500;
            var g = 15;
            var h = "nieuprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && h != null && d.Length > 6
                && result1 == true && result2 == true && result3 == true && result6 == true)
            {
                u.FirstName = a;
                u.LastName = b;
                u.Login = c;
                u.PasswordHash = d;
                u.CodeHash = e;
                u.BaseSalary = f;
                u.HourlyRate = g;
                u.Permission = h;

            }
            Assert.IsNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNull(u.login, "Uzupe³nij login");
            Assert.IsNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void UPDATEUSER6()
        {
            var a = "Adam";
            var b = "Nowakowski";
            var c = "NowaKo";
            var d = "Nowak123";
            string e = null;
            var f = 2500;
            var g = 15;
            var h = "nieuprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && h != null && d.Length > 6
                && result1 == true && result2 == true && result3 == true && result4 == true && result5 == true)
            {
                u.FirstName = a;
                u.LastName = b;
                u.Login = c;
                u.PasswordHash = d;
                u.CodeHash = e;
                u.BaseSalary = f;
                u.HourlyRate = g;
                u.Permission = h;

            }
            Assert.IsNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNull(u.login, "Uzupe³nij login");
            Assert.IsNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void UPDATEUSER7()
        {
            var a = "Adam";
            var b = "Nowakowski";
            var c = "NowaKo";
            var d = "Nowak123";
            var e = "227va546hg";
            var f = 0;
            var g = 15;
            var h = "nieuprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

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

            }
            Assert.IsNotNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNotNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNotNull(u.login, "Uzupe³nij login");
            Assert.IsNotNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNotNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNotNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void UPDATEUSER8()
        {
            var a = "Adam";
            var b = "Nowakowski";
            var c = "NowaKo";
            var d = "Nowak123";
            var e = "227va546hg";
            var f = 2500;
            var g = 0;
            var h = "nieuprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

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

            }
            Assert.IsNotNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNotNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNotNull(u.login, "Uzupe³nij login");
            Assert.IsNotNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNotNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNotNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void UPDATEUSER9()
        {
            var a = "Adam";
            var b = "Nowakowski";
            var c = "NowaKo";
            var d = "Nowak123";
            var e = "227va546hg";
            var f = 2500;
            var g = 15;
            string h = null;

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && h != null && d.Length > 6
                && result1 == true && result2 == true && result4 == true && result5 == true && result6 == true)
            {
                u.FirstName = a;
                u.LastName = b;
                u.Login = c;
                u.PasswordHash = d;
                u.CodeHash = e;
                u.BaseSalary = f;
                u.HourlyRate = g;
                u.Permission = h;

            }
            Assert.IsNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNull(u.login, "Uzupe³nij login");
            Assert.IsNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void UPDATEUSER10()
        {
            var a = "(^(&";
            var b = "Nowakowski";
            var c = "NowaKo";
            var d = "Nowak123";
            var e = "227va546hg";
            var f = 2500;
            var g = 15;
            var h = "nieuprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

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

            }
            Assert.IsTrue(result1 == false);
            Assert.IsTrue(result2 == true);
            Assert.IsTrue(result3 == true);
            Assert.IsTrue(result4 == true);
            Assert.IsTrue(result5 == true);
            Assert.IsTrue(result6 == true);
        }

        [TestMethod]
        public void UPDATEUSER11()
        {
            var a = "Adam";
            var b = "(*^&(^";
            var c = "NowaKo";
            var d = "Nowak123";
            var e = "227va546hg";
            var f = 2500;
            var g = 15;
            var h = "nieuprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

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

            }
            Assert.IsTrue(result1 == true);
            Assert.IsTrue(result2 == false);
            Assert.IsTrue(result3 == true);
            Assert.IsTrue(result4 == true);
            Assert.IsTrue(result5 == true);
            Assert.IsTrue(result6 == true);
        }

        [TestMethod]
        public void UPDATEUSER12()
        {
            var a = "Adam";
            var b = "Nowakowski";
            var c = "*(^&(";
            var d = "Nowak123";
            var e = "227va546hg";
            var f = 2500;
            var g = 15;
            var h = "nieuprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

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

            }
            Assert.IsTrue(result1 == true);
            Assert.IsTrue(result2 == true);
            Assert.IsTrue(result3 == true);
            Assert.IsTrue(result4 == false);
            Assert.IsTrue(result5 == true);
            Assert.IsTrue(result6 == true);
        }

        [TestMethod]
        public void UPDATEUSER13()
        {
            var a = "Adam";
            var b = "Nowakowski";
            var c = "NowaKo";
            var d = "(^&^*)";
            var e = "227va546hg";
            var f = 2500;
            var g = 15;
            var h = "nieuprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

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

            }
            Assert.IsTrue(result1 == true);
            Assert.IsTrue(result2 == true);
            Assert.IsTrue(result3 == true);
            Assert.IsTrue(result4 == true);
            Assert.IsTrue(result5 == false);
            Assert.IsTrue(result6 == true);
        }

        [TestMethod]
        public void UPDATEUSER14()
        {
            var a = "Adam";
            var b = "Nowakowski";
            var c = "NowaKo";
            var d = "Nowak123";
            var e = "*(*(^*(";
            var f = 2500;
            var g = 15;
            var h = "nieuprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

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

            }
            Assert.IsTrue(result1 == true);
            Assert.IsTrue(result2 == true);
            Assert.IsTrue(result3 == true);
            Assert.IsTrue(result4 == true);
            Assert.IsTrue(result5 == true);
            Assert.IsTrue(result6 == false);
        }

        [TestMethod]
        public void UPDATEUSER15()
        {
            var a = "Adam";
            var b = "Nowakowski";
            var c = "NowaKo";
            var d = "Nowak123";
            var e = "227va546hg";
            var f = 2500;
            var g = 15;
            var h = "^(^&*^(::;";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

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

            }
            Assert.IsTrue(result1 == true);
            Assert.IsTrue(result2 == true);
            Assert.IsTrue(result3 == false);
            Assert.IsTrue(result4 == true);
            Assert.IsTrue(result5 == true);
            Assert.IsTrue(result6 == true);
        }

        [TestMethod]
        public void DELETEUSER()
        {
            int i = 1;
            var a = "Jan";
            var b = "Kowalski";
            var c = "Jankow";
            var d = "Jan1234";
            var e = "887va4n4432m";
            var f = 3000;
            var g = 17;
            var h = "uprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && result1 == true && result2 == true && result3 == true
                && result4 == true && result5 == true && result6 == true && i > 0 && f > 0 && g > 0)
            {
                u.FirstName = null;
                u.LastName = null;
                u.Login = null;
                u.PasswordHash = null;
                u.CodeHash = null;
                u.BaseSalary = 0;
                u.HourlyRate = 0;
                u.Permission = null;

            }
            Assert.IsNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNull(u.login, "Uzupe³nij login");
            Assert.IsNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void DELETEUSER2()
        {
            int i = 1;
            string a = null;
            var b = "Kowalski";
            var c = "Jankow";
            var d = "Jan1234";
            var e = "887va4n4432m";
            var f = 3000;
            var g = 17;
            var h = "uprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && result2 == true && result3 == true
                && result4 == true && result5 == true && result6 == true && i > 0 && f > 0 && g > 0)
            {
                u.FirstName = null;
                u.LastName = null;
                u.Login = null;
                u.PasswordHash = null;
                u.CodeHash = null;
                u.BaseSalary = 0;
                u.HourlyRate = 0;
                u.Permission = null;

            }
            Assert.IsNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNull(u.login, "Uzupe³nij login");
            Assert.IsNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void DELETEUSER3()
        {
            int i = 1;
            var a = "Jan";
            string b = null;
            var c = "Jankow";
            var d = "Jan1234";
            var e = "887va4n4432m";
            var f = 3000;
            var g = 17;
            var h = "uprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && result1 == true && result3 == true
                && result4 == true && result5 == true && result6 == true && i > 0 && f > 0 && g > 0)
            {
                u.FirstName = null;
                u.LastName = null;
                u.Login = null;
                u.PasswordHash = null;
                u.CodeHash = null;
                u.BaseSalary = 0;
                u.HourlyRate = 0;
                u.Permission = null;

            }
            Assert.IsNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNull(u.login, "Uzupe³nij login");
            Assert.IsNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void DELETEUSER4()
        {
            int i = 1;
            var a = "Jan";
            var b = "Kowalski";
            string c = null;
            var d = "Jan1234";
            var e = "887va4n4432m";
            var f = 3000;
            var g = 17;
            var h = "uprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && result1 == true && result2 == true && result3 == true
                && result5 == true && result6 == true && i > 0 && f > 0 && g > 0)
            {
                u.FirstName = null;
                u.LastName = null;
                u.Login = null;
                u.PasswordHash = null;
                u.CodeHash = null;
                u.BaseSalary = 0;
                u.HourlyRate = 0;
                u.Permission = null;

            }
            Assert.IsNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNull(u.login, "Uzupe³nij login");
            Assert.IsNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void DELETEUSER5()
        {
            int i = 1;
            var a = "Jan";
            var b = "Kowalski";
            var c = "Jankow";
            string d = null;
            var e = "887va4n4432m";
            var f = 3000;
            var g = 17;
            var h = "uprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && result1 == true && result2 == true && result3 == true
                && result4 == true && result6 == true && i > 0 && f > 0 && g > 0)
            {
                u.FirstName = null;
                u.LastName = null;
                u.Login = null;
                u.PasswordHash = null;
                u.CodeHash = null;
                u.BaseSalary = 0;
                u.HourlyRate = 0;
                u.Permission = null;

            }
            Assert.IsNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNull(u.login, "Uzupe³nij login");
            Assert.IsNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void DELETEUSER6()
        {
            int i = 1;
            var a = "Jan";
            var b = "Kowalski";
            var c = "Jankow";
            var d = "Jan1234";
            string e = null;
            var f = 3000;
            var g = 17;
            var h = "uprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && result1 == true && result2 == true && result3 == true
                && result4 == true && result5 == true && i > 0 && f > 0 && g > 0)
            {
                u.FirstName = null;
                u.LastName = null;
                u.Login = null;
                u.PasswordHash = null;
                u.CodeHash = null;
                u.BaseSalary = 0;
                u.HourlyRate = 0;
                u.Permission = null;

            }
            Assert.IsNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNull(u.login, "Uzupe³nij login");
            Assert.IsNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void DELETEUSER7()
        {
            int i = 1;
            var a = "Jan";
            var b = "Kowalski";
            var c = "Jankow";
            var d = "Jan1234";
            var e = "887va4n4432m";
            var f = 0;
            var g = 17;
            var h = "uprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && result1 == true && result2 == true && result3 == true
                && result4 == true && result5 == true && result6 == true && i > 0 && f > 0 && g > 0)
            {
                u.FirstName = null;
                u.LastName = null;
                u.Login = null;
                u.PasswordHash = null;
                u.CodeHash = null;
                u.BaseSalary = 0;
                u.HourlyRate = 0;
                u.Permission = null;

            }
            Assert.IsNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNull(u.login, "Uzupe³nij login");
            Assert.IsNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void DELETEUSER8()
        {
            int i = 1;
            var a = "Jan";
            var b = "Kowalski";
            var c = "Jankow";
            var d = "Jan1234";
            var e = "887va4n4432m";
            var f = 3000;
            var g = 0;
            var h = "uprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && result1 == true && result2 == true && result3 == true
                && result4 == true && result5 == true && result6 == true && i > 0 && f > 0 && g > 0)
            {
                u.FirstName = null;
                u.LastName = null;
                u.Login = null;
                u.PasswordHash = null;
                u.CodeHash = null;
                u.BaseSalary = 0;
                u.HourlyRate = 0;
                u.Permission = null;

            }
            Assert.IsNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNull(u.login, "Uzupe³nij login");
            Assert.IsNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void DELETEUSER9()
        {
            int i = 1;
            var a = "Jan";
            var b = "Kowalski";
            var c = "Jankow";
            var d = "Jan1234";
            var e = "887va4n4432m";
            var f = 3000;
            var g = 17;
            string h = null;

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && result1 == true && result2 == true
                && result4 == true && result5 == true && result6 == true && i > 0 && f > 0 && g > 0 && h != null)
            {
                u.FirstName = null;
                u.LastName = null;
                u.Login = null;
                u.PasswordHash = null;
                u.CodeHash = null;
                u.BaseSalary = 0;
                u.HourlyRate = 0;
                u.Permission = null;

            }
            Assert.IsNull(u.firstName, "Uzupe³nij imiê");
            Assert.IsNull(u.lastName, "Uzupe³nij nazwisko");
            Assert.IsNull(u.login, "Uzupe³nij login");
            Assert.IsNull(u.passwordHash, "Uzupe³nij has³o");
            Assert.IsNull(u.codeHash, "Uzupe³nij hash");
            Assert.IsNotNull(u.baseSalary, "Uzupe³nij pensjê");
            Assert.IsNotNull(u.hourlyRate, "Uzupe³nij stawkê godzinow¹");
            Assert.IsNull(u.permission, "Uzupe³nij uprawnienia");
        }

        [TestMethod]
        public void DELETEUSER10()
        {
            int i = 1;
            var a = "(*^%^&*";
            var b = "Kowalski";
            var c = "Jankow";
            var d = "Jan1234";
            var e = "887va4n4432m";
            var f = 3000;
            var g = 17;
            var h = "uprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && result1 == true && result2 == true && result3 == true
                && result4 == true && result5 == true && result6 == true && i > 0 && f > 0 && g > 0)
            {
                u.FirstName = null;
                u.LastName = null;
                u.Login = null;
                u.PasswordHash = null;
                u.CodeHash = null;
                u.BaseSalary = 0;
                u.HourlyRate = 0;
                u.Permission = null;

            }
            Assert.IsTrue(result1 == false);
            Assert.IsTrue(result2 == true);
            Assert.IsTrue(result3 == true);
            Assert.IsTrue(result4 == true);
            Assert.IsTrue(result5 == true);
            Assert.IsTrue(result6 == true);
        }

        [TestMethod]
        public void DELETEUSER11()
        {
            int i = 1;
            var a = "Jan";
            var b = ")*^&*^*(";
            var c = "Jankow";
            var d = "Jan1234";
            var e = "887va4n4432m";
            var f = 3000;
            var g = 17;
            var h = "uprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && result1 == true && result2 == true && result3 == true
                && result4 == true && result5 == true && result6 == true && i > 0 && f > 0 && g > 0)
            {
                u.FirstName = null;
                u.LastName = null;
                u.Login = null;
                u.PasswordHash = null;
                u.CodeHash = null;
                u.BaseSalary = 0;
                u.HourlyRate = 0;
                u.Permission = null;

            }
            Assert.IsTrue(result1 == true);
            Assert.IsTrue(result2 == false);
            Assert.IsTrue(result3 == true);
            Assert.IsTrue(result4 == true);
            Assert.IsTrue(result5 == true);
            Assert.IsTrue(result6 == true);
        }

        [TestMethod]
        public void DELETEUSER12()
        {
            int i = 1;
            var a = "Jan";
            var b = "Kowalski";
            var c = "Jankow";
            var d = "Jan1234";
            var e = "887va4n4432m";
            var f = 3000;
            var g = 17;
            var h = "*^(^%^&*&";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && result1 == true && result2 == true && result3 == true
                && result4 == true && result5 == true && result6 == true && i > 0 && f > 0 && g > 0)
            {
                u.FirstName = null;
                u.LastName = null;
                u.Login = null;
                u.PasswordHash = null;
                u.CodeHash = null;
                u.BaseSalary = 0;
                u.HourlyRate = 0;
                u.Permission = null;

            }
            Assert.IsTrue(result1 == true);
            Assert.IsTrue(result2 == true);
            Assert.IsTrue(result3 == false);
            Assert.IsTrue(result4 == true);
            Assert.IsTrue(result5 == true);
            Assert.IsTrue(result6 == true);
        }

        [TestMethod]
        public void DELETEUSER13()
        {
            int i = 1;
            var a = "Jan";
            var b = "Kowalski";
            var c = "*%^(&(";
            var d = "Jan1234";
            var e = "887va4n4432m";
            var f = 3000;
            var g = 17;
            var h = "uprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && result1 == true && result2 == true && result3 == true
                && result4 == true && result5 == true && result6 == true && i > 0 && f > 0 && g > 0)
            {
                u.FirstName = null;
                u.LastName = null;
                u.Login = null;
                u.PasswordHash = null;
                u.CodeHash = null;
                u.BaseSalary = 0;
                u.HourlyRate = 0;
                u.Permission = null;

            }
            Assert.IsTrue(result1 == true);
            Assert.IsTrue(result2 == true);
            Assert.IsTrue(result3 == true);
            Assert.IsTrue(result4 == false);
            Assert.IsTrue(result5 == true);
            Assert.IsTrue(result6 == true);
        }

        [TestMethod]
        public void DELETEUSER14()
        {
            int i = 1;
            var a = "Jan";
            var b = "Kowalski";
            var c = "Jankow";
            var d = "(^*^^(::>?/";
            var e = "887va4n4432m";
            var f = 3000;
            var g = 17;
            var h = "uprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && result1 == true && result2 == true && result3 == true
                && result4 == true && result5 == true && result6 == true && i > 0 && f > 0 && g > 0)
            {
                u.FirstName = null;
                u.LastName = null;
                u.Login = null;
                u.PasswordHash = null;
                u.CodeHash = null;
                u.BaseSalary = 0;
                u.HourlyRate = 0;
                u.Permission = null;

            }
            Assert.IsTrue(result1 == true);
            Assert.IsTrue(result2 == true);
            Assert.IsTrue(result3 == true);
            Assert.IsTrue(result4 == true);
            Assert.IsTrue(result5 == false);
            Assert.IsTrue(result6 == true);
        }

        [TestMethod]
        public void DELETEUSER15()
        {
            int i = 1;
            var a = "Jan";
            var b = "Kowalski";
            var c = "Jankow";
            var d = "Jan1234";
            var e = "_)&()%$#@";
            var f = 3000;
            var g = 17;
            var h = "uprzywilejowany";

            Regex rex = new Regex("^[a-zêó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result1 = rex.IsMatch(a);
            Boolean result2 = rex.IsMatch(b);
            Boolean result3 = rex.IsMatch(h);

            Regex rex2 = new Regex("^[a-z0-9êó¹œ³¿Ÿæñ ]+$", RegexOptions.IgnoreCase);

            Boolean result4 = rex2.IsMatch(c);
            Boolean result5 = rex2.IsMatch(d);
            Boolean result6 = rex2.IsMatch(e);

            User u = new User();
            if (a != null && b != null && c != null && d != null && e != null && result1 == true && result2 == true && result3 == true
                && result4 == true && result5 == true && result6 == true && i > 0 && f > 0 && g > 0)
            {
                u.FirstName = null;
                u.LastName = null;
                u.Login = null;
                u.PasswordHash = null;
                u.CodeHash = null;
                u.BaseSalary = 0;
                u.HourlyRate = 0;
                u.Permission = null;

            }
            Assert.IsTrue(result1 == true);
            Assert.IsTrue(result2 == true);
            Assert.IsTrue(result3 == true);
            Assert.IsTrue(result4 == true);
            Assert.IsTrue(result5 == true);
            Assert.IsTrue(result6 == false);
        }

    }
}
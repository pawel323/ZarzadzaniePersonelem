using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModułZarządzaniaPersonelem
{
    class ScheduleStatus
    {
        private string nameStatus;

        private int scheduleStatus_ID;
        public string NameStatus
        {
            get
            {
                return nameStatus;
            }
            set
            {
                if (value != null && value is String)
                {
                    nameStatus = value;
                }
                else
                {
                    MessageBox.Show("Uzupełnij nazwę statusu");
                    return;
                }
            }
        }
        public int ScheduleStatus_ID { get => scheduleStatus_ID; }

       public override string ToString()
        {
            return nameStatus;
        }
    }
}
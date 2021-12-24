using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ApplicationLauncher
{
    [Serializable()]
    class programInfo
    {
        public string name;
        public string fileLocation;
        public bool lastRun;

        //Properties to get and set the arrays
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string FileLocation
        {
            get => fileLocation;
            set => fileLocation = value;
        }
        public bool LastRun
        {
            get => lastRun;
            set => lastRun = value;
        }

        public string ResetInfo()
        {
            name = "";
            fileLocation = "";
            lastRun = false;
            return "Sucess!";
        }
        public programInfo(string programName, string programFileLocation, bool isChecked)
        {
            name = programName;
            fileLocation = programFileLocation;
            lastRun = isChecked;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pracownicy.Views;
using Pracownicy.Models;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System.Xml.Serialization;

namespace Pracownicy.Presenters
{
    public class WorkerPresenter
    {
        IWorker workerView;
        public List<Worker> workers = new List<Worker>();
        public WorkerPresenter(IWorker view)
        {   
            workerView = view;
        }
        public void Adding()
        {
            Worker worker = new Worker();
            worker.Name = workerView.NameText;
            worker.Surname = workerView.SurnameText;
            worker.DateOfBirth = workerView.DateOfBirthDTP;
            worker.Salary = workerView.SalaryNUD;
            worker.Position = workerView.PositionCB;
            worker.TypeOfContract = workerView.TypeOfContractRB;
            workers.Add(worker);
        }
        public void Display()
        {
            var lastWorker = workers.Last();
            string temp = $"{lastWorker.Name} {lastWorker.Surname}, {lastWorker.DateOfBirth}, {lastWorker.Position}, {lastWorker.Salary} PLN, {lastWorker.TypeOfContract}";
            workerView.TextDisplay = temp;
        }
        public void DisplayAll()
        {

            foreach (Worker w in workers)
            {
                string temp = $"{w.Name} {w.Surname}, {w.DateOfBirth}, {w.Position}, {w.Salary} PLN, {w.TypeOfContract}";
                workerView.TextDisplay = temp;
            }
        }
        public void AutoAdd(int index) 
        {
            try
            {
                workerView.NameText = workers[index].Name;
                workerView.SurnameText = workers[index].Surname;
                workerView.DateOfBirthDTP = workers[index].DateOfBirth;
                workerView.SalaryNUD = workers[index].Salary;
                workerView.PositionCB = workers[index].Position;
                workerView.TypeOfContractRB = workers[index].TypeOfContract;
            }
            catch { }
        }
        public void Save()
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "xml files (*.xml)|*.xml";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Worker>));
                    serializer.Serialize(myStream, workers);
                    myStream.Close();
                }
            }
        }
        public void Load()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "xml files (*.xml)|*.xml";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Worker>));

                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    workers = (List<Worker>)serializer.Deserialize(fileStream);

                    DisplayAll();

                    fileStream.Close();
                }
            }

        }
    }
}

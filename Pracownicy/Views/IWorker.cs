using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy.Views
{
    public interface IWorker
    {
        string NameText { get; set; }
        string SurnameText { get; set; }
        string DateOfBirthDTP { get; set; }
        string SalaryNUD { get; set; }
        string PositionCB { get; set; }
        string TextDisplay { get; set; }
        string TypeOfContractRB { get; set; }
        event EventHandler AddAttempted;
        event EventHandler SaveAttempted;
        event EventHandler LoadAttempted;
    }
}

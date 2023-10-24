using PropertyChanged;
using System.Windows.Input;

namespace Calculator.MVVM
{
    [AddINotifyPropertyChangedInterface]
    public class CalculatorViewModel
    {
        public string Formula { get; set; }
        public string Result { get; set; } = "0";

        public ICommand OperationCommand => new Command((number) =>
        {
            Formula += number;
        });

        public ICommand ResetCommand => new Command(() =>
        {
            Formula = "";
            Result = "0";
        });

        public ICommand BackspaceCommand => new Command(() =>
        {
            if (Formula.Length > 0)
            {
                Formula = Formula.Substring(0, Formula.Length - 1);
            }
        });

        public ICommand CalculateCommand => new Command(() =>
        {
            if (Formula.Length == 0)
            {
                return;
            }
            Result = Dangl.Calculator.Calculator.Calculate(Formula).Result.ToString();
        });
    }
}

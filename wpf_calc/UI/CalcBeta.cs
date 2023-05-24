using System.Globalization;
using System.Windows;
using System.Windows.Input;
using BmMathLib;
using AutoUpdaterDotNET;
using wpf_calc_beta.Code;
using wpf_calc_beta.UI;
using System.Windows.Controls;
using System.Reflection;

// ReSharper disable UnusedMember.Global

namespace wpf_calc_beta
{
    /// <summary>
    /// Interaction logic for CalcBeta.xaml
    /// </summary>
    public partial class CalcBeta
    {
        private readonly MathCalculatorCore _calc = new MathCalculatorCore();

        private string ExpressionText
        {
            get => MathTb.Text;
            set => MathTb.Text = value;
        }

        private string ResultText
        {
            get => ResultTb.Text;
            set => ResultTb.Text = "=" + value;
        }

        public CalcBeta()
        {
            InitializeComponent();

            //Autoupdate
            if (Properties.Settings.Default.ChBoxUpdate == true)
            {
                AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;
                AutoUpdater.Start("http://bm.stolenbase.ru/calculator/update.xml");
            }

            //Here our settings are loading
            lVer.Content = $"Calculator({Assembly.GetExecutingAssembly().GetName().Version})";
            ChBoxSave.IsChecked = Properties.Settings.Default.ChBoxSave;
            ChBoxUpdate.IsChecked = Properties.Settings.Default.ChBoxUpdate;
            if ((bool)ChBoxSave.IsChecked)
            {
                _calc.MathString = Properties.Settings.Default.mathExpression;
            }
            else
            {
                _calc.MathString = "0";
            }
            WriteExpression();
        }

        private class HistoryItem
        {
            public string Expression { get; set; }
            public string Result { get; set; }
        }

        private void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            if (args.IsUpdateAvailable)
            {
                if (Updater.Show($"Calculator update available.\n{args.InstalledVersion} -> {args.CurrentVersion}"))
                {
                    Close();
                    AutoUpdater.DownloadUpdate(args);
                }
            }
        }

        private void WriteExpression()
        {
            ExpressionText = _calc.MathString;
            WriteToResult();
        }

        private void PrepareExpression(string sender)
        {
            switch (sender)
            {
                case ("1"):
                case ("2"):
                case ("3"):
                case ("4"):
                case ("5"):
                case ("6"):
                case ("7"):
                case ("8"):
                case ("9"):
                case ("0"):
                    _calc.NumberClick(sender);
                    break;
                case (MathStuff.Plus):
                case (MathStuff.Minus):
                case (MathStuff.Div):
                case (MathStuff.Mult):
                    _calc.ActionClick(sender);
                    break;
                case (MathStuff.Sine):
                case (MathStuff.Cosine):
                case (MathStuff.Tangent):
                case (MathStuff.Cotangent):
                case (MathStuff.Lg):
                case (MathStuff.Log):
                case (MathStuff.Ln):
                    _calc.FunctionClick(sender);
                    break;
                case (MathStuff.Root):
                    _calc.SqrtClick();
                    break;
                case (MathStuff.Pow):
                    _calc.PowClick();
                    break;
                case (MathStuff.Fact):
                    _calc.FactorialClick();
                    break;
                case (MathStuff.Comma):
                case (MathStuff.Deg):
                    _calc.SpecClick(sender);
                    break;
                case (MathStuff.Pi):
                case (MathStuff.Exp):
                    _calc.ConstantClick(sender);
                    break;
                case (MathStuff.Dot):
                    _calc.DotClick();
                    break;
                case (MathStuff.Equal):
                    if (ResultText.Contains("Error") ||
                        ResultText.Contains(double.PositiveInfinity.ToString(CultureInfo.CurrentCulture))) break;
                    WriteToHistory();
                    _calc.EqualClick();
                    break;
                case ("("):
                case (")"):
                    _calc.BracketClick(sender);
                    break;
                case ("r"):
                    _calc.RemoveClick();
                    break;
                case ("c"):
                    _calc.Clear();
                    break;
            }
            Properties.Settings.Default.mathExpression = _calc.MathString;
            Properties.Settings.Default.Save();
            WriteExpression();
        }

        private void WriteToHistory()
        {
            HistoryList.Items.Insert(0, new HistoryItem() { Expression = ExpressionText, Result = ResultText });
            Properties.Settings.Default.Save();
        }
        private void WriteToResult()
        {
            var result = _calc.EvaluateExpression();
            //Show result or not?
            TextBoxes.RowDefinitions[1].Height = result == _calc.MakeExpression(ExpressionText) ||
                                                 result == string.Empty
                ? new GridLength(0.0, GridUnitType.Star)
                : new GridLength(30.0, GridUnitType.Star);
            ResultText = result;
        }

        private void ButtonClick(object sender, RoutedEventArgs e) => PrepareExpression(ButtonClickHandler.HandleSender(sender));

        private void FunctionShowClick(object sender, RoutedEventArgs e)
        {
            CalcGrid.RowDefinitions[2].Height =
                CalcGrid.RowDefinitions[2].Height == new GridLength(30, GridUnitType.Star)
                    ? new GridLength(0, GridUnitType.Star)
                    : new GridLength(30, GridUnitType.Star);
        }

        private void KeyboardPress(object sender, KeyEventArgs e) => PrepareExpression(KeyboardModule.KeyClickHandle(e.Key));

        private void CheckBoxClick(object sender, RoutedEventArgs e)
        {
            switch(((CheckBox) sender).Name)
            {
                case ("ChBoxSave"):
                    if (ChBoxSave.IsChecked != null && (bool)ChBoxSave.IsChecked)
                    {
                        Properties.Settings.Default.ChBoxSave = true;
                    }
                    else
                    {
                        Properties.Settings.Default.ChBoxSave = false;
                    }
                    break;
                case ("ChBoxUpdate"):
                    if (ChBoxUpdate.IsChecked != null && (bool)ChBoxUpdate.IsChecked)
                    {
                        Properties.Settings.Default.ChBoxUpdate = true;
                    }
                    else
                    {
                        Properties.Settings.Default.ChBoxUpdate = false;
                    }
                    break;
            }
            Properties.Settings.Default.Save();
        }

        private void ShowHistory(object sender, SizeChangedEventArgs e)
        {
            if(e.NewSize.Width >= 500)
            {
                CalcGrid.ColumnDefinitions[1].Width = new GridLength(40, GridUnitType.Star);
            }
            else
            {
                CalcGrid.ColumnDefinitions[1].Width = new GridLength(0, GridUnitType.Star);
            }
        }
    }
}
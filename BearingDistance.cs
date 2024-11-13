using Humanizer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BearingsAndDistancesParser
{
    public partial class BearingDistance : UserControl
    {
        public BearingDistance(Line line)
        {
            InitializeComponent();
            foreach(var direction in HelperCollections.Directions)
            {
                cmbDirection1.Items.Add(direction);
                cmbDirection2.Items.Add(direction);
            }

            cmbDirection1.SelectedItem = line.Direction1;
            txtDegrees.Text = line.Degrees;
            txtMinutes.Text = line.Minutes;
            txtSeconds.Text = line.Seconds;
            cmbDirection2.SelectedItem = line.Direction2;
            txtDistance.Text = line.Distance.ToString();
            txtDescription.Text = line.Description;
        }

        public string GetLineTranslation()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("a bearing of ");
            stringBuilder.Append($"{HelperCollections.DirectionMap[cmbDirection1.SelectedItem.ToString()]} ");
            stringBuilder.Append($"{int.Parse(txtDegrees.Text).ToWords()} ({txtDegrees.Text}) degrees ");
            stringBuilder.Append($"{int.Parse(txtMinutes.Text).ToWords()} ({txtMinutes.Text}) minutes ");
            stringBuilder.Append($"{int.Parse(txtSeconds.Text).ToWords()} ({txtSeconds.Text}) seconds ");
            stringBuilder.Append($"{HelperCollections.DirectionMap[cmbDirection2.SelectedItem.ToString()]} ");

            var distanceValues = txtDistance.Text.Split('.');
            var distanceValue1 = int.Parse(distanceValues[0]);
            var distanceString1 = string.Empty;

            if(distanceValue1 > 100)
            {
                var distance1Values = ((decimal)distanceValue1 / 100).ToString().Split('.');
                var hundredsString = (int.Parse(distance1Values[0]) * 100).ToWords();
                var decimalValue = (distance1Values.Length > 1 ? (int.Parse(distance1Values[1])).ToWords() : "");
                distanceString1 = $"{hundredsString} {decimalValue}";
            }
            else
            {
                distanceString1 = int.Parse(distanceValues[0]).ToWords();
            }

            var distanceString2 = string.Empty;
            decimal distanceValue2 = Decimal.Parse(distanceValues[1]);

            if (distanceValue2 > 100)
            {
                distanceValue2 = Math.Round(((distanceValue2 / 100) * 10), MidpointRounding.AwayFromZero);
            }

            var distanceValue2Int = distanceValue2;
            distanceString2 = ((int)distanceValue2Int).ToWords();

            stringBuilder.Append($"with a distance of {distanceString1} and {(distanceValues[1] == "00" ? "no" : distanceString2)} one-hundredths ({distanceValues[0]}.{(distanceValue2Int == 0 ? "00" : distanceValue2Int)}) ");

            var isFirstLetterVowelOrY = HelperCollections.VowelList.Contains(txtDescription.Text.First());
            stringBuilder.Append($"to {(isFirstLetterVowelOrY ? "an" : "a")} {txtDescription.Text}; ");

            return stringBuilder.ToString();
        }

        private void txtDegrees_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericOnlyKeyPress(sender, e);
        }

        private void txtMinutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericOnlyKeyPress(sender, e);
        }

        private void txtSeconds_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericOnlyKeyPress(sender, e);
        }

        private void txtDistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericOnlyWithDecimalKeyPress(sender, e);
        }

        private void NumericOnlyKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NumericOnlyWithDecimalKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;

            }
        }
    }
}

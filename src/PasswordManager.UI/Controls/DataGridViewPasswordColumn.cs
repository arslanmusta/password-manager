using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.UI.Controls
{
    public class DataGridViewPasswordColumn : DataGridViewTextBoxColumn
    {
        public DataGridViewPasswordColumn()
        {
            this.CellTemplate = new DataGriViewPasswordCell();
        }
    }
    public class DataGriViewPasswordCell : DataGridViewTextBoxCell
    {
        public override void InitializeEditingControl(int rowIndex,
            object initialFormattedValue,
            DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex,
                initialFormattedValue, dataGridViewCellStyle);
            ((TextBox)this.DataGridView.EditingControl).UseSystemPasswordChar = true;
        }
        protected override void Paint(Graphics graphics,
            Rectangle clipBounds, Rectangle cellBounds,
            int rowIndex, DataGridViewElementStates cellState,
            object value, object formattedValue,
            string errorText, DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            var i = $"{formattedValue}".Length;
            formattedValue = new string('●', i);
            base.Paint(graphics, clipBounds, cellBounds, rowIndex,
                cellState, value, formattedValue,
                errorText, cellStyle, advancedBorderStyle, paintParts);
        }
    }
}

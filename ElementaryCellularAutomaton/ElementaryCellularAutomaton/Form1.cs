using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementaryCellularAutomaton
{
    public partial class Form_main : Form
    {
        private int[] previous_state;
        private int[] current_state;
        private int state_num;

        int cell_count = 32;
        int cell_height;

        public Form_main()
        {
            InitializeComponent();
            SetupDataGridView(cell_count + 1, 1);
            InitializeStartState();
        }

        private void SetupDataGridView(int n, int m)
        {
            cell_height = dataGridView_Space.Width / cell_count;
            dataGridView_Space.RowTemplate.Height = cell_height;
            dataGridView_Space.ColumnCount = n;
            dataGridView_Space.RowCount = m;
        }

        private void DrawCurrentState()
        {
            if (state_num >= dataGridView_Space.RowCount)
                return;

            dataGridView_Space.Rows[state_num].Cells[0].Value = state_num;

            for (int i = 0; i < current_state.Length; i++)
            {
                var cell = dataGridView_Space.Rows[state_num].Cells[i + 1];

                if (current_state[i] == 1)
                {
                    cell.Style.BackColor = Color.Green;
                }
                else
                {
                    cell.Style.BackColor = Color.White;
                }
            }

        }

        private void InitializeStartState()
        {
            Random rand = new Random();
            state_num = 0;
            current_state = new int[cell_count];

            for (int i = 0; i < current_state.Length; i++)
            {
                current_state[i] = rand.Next(2);
            }

            // тест из презентации лекции
            // current_state = new int[] { 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0 };

            // для правила 90
            // current_state = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

            previous_state = new int[cell_count];
            Array.Copy(current_state, previous_state, current_state.Length);
            DrawCurrentState();
        }

        private void CalculateCurrentState(int rule)
        {
            state_num++;

            List<string> status_dictionary = new List<string> { "111", "110", "101", "100", "011", "010", "001", "000" };
            string binaryRule = Convert.ToString(rule, 2).PadLeft(8, '0');

            Dictionary<string, int> rules_dictionary = new Dictionary<string, int>();
            for (int i = 0; i < status_dictionary.Count; i++)
            {
                rules_dictionary[status_dictionary[i]] = binaryRule[i] - '0'; // Преобразуем символ '0' или '1' в int
            }

            string previous_status;
            for (int i = 1; i < current_state.Length - 1; i++)
            {
                previous_status = $"{previous_state[i - 1]}{previous_state[i]}{previous_state[i + 1]}";
                current_state[i] = rules_dictionary[previous_status];
            }

            // для первой клетки
            previous_status = $"{previous_state[current_state.Length - 1]}{previous_state[0]}{previous_state[1]}";
            current_state[0] = rules_dictionary[previous_status];

            // для последней клетки
            previous_status = $"{previous_state[current_state.Length - 2]}{previous_state[current_state.Length - 1]}{previous_state[0]}";
            current_state[current_state.Length - 1] = rules_dictionary[previous_status];

            Array.Copy(current_state, previous_state, current_state.Length);
            dataGridView_Space.Rows.Add();
            DrawCurrentState();
        }

        int flag = 0; // 0 - stop, 1 - start
        int ruleValue;

        private void button_StartStop_Click(object sender, EventArgs e)
        {
            //Validation
            string rule = textBox_Rule.Text;

            if (!int.TryParse(rule, out ruleValue) || ruleValue < 0 || ruleValue > 255)
            {
                MessageBox.Show("Введите корректное значение для правила!");
                return;
            }

            if (flag == 0)
            {
                timer.Start();
                flag = 1;
            }
            else
            {
                timer.Stop();
                flag = 0;
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CalculateCurrentState(ruleValue);
        }
    }
}

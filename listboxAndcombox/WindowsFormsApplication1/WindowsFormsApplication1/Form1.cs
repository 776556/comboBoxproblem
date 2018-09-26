using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    { 
        Boolean showMsg = true;
        public Form1()
        {
            InitializeComponent();
        }
        class Menu
        {
            public String bentoName { get; set; }
            public int bentoPrice { get; set; }
            public int OrderQty { get; set; }
            public int TPrice { get; set; }


        }
        private void upcomboBox()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = newmenu;
            comboBox1.DisplayMember = "bentoName";
            comboBox1.ValueMember = "bentoName";
        }
        private void uplistBox()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = newmenu;
            listBox1.DisplayMember = "bentoName";
        }
        List<Menu> newmenu = new List<Menu>();

        private void selectData()
        {
            for (int i = 0; i < 8; i++)
            {
                newmenu.Add(new Menu() { bentoName = "測試" + i, bentoPrice = 100 });
            }
                 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            selectData();//list塞 newmenu.Add(new Menu() { bentoName = "測試" + i, bentoPrice = 100 });
            uplistBox();//list塞進listBox 並做設定讓listBox顯示 bentoName的值
            upcomboBox();//list塞進comboBox並做設定comboBox顯示 bentoName的值
         
        }
        int listBoxRemoveIndex;
       
        private void button1_Click(object sender, EventArgs e)//刪除扭
        {
            newmenu.RemoveAt(listBoxRemoveIndex);
            uplistBox();           
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {          
            listBoxRemoveIndex = listBox1.IndexFromPoint(e.X, e.Y);           
            comboBox1.DataSource = null;
            comboBox1.DataSource = newmenu;
            comboBox1.DisplayMember = "bentoName";
            comboBox1.SelectedIndex = listBoxRemoveIndex;
        }

 
    }
}

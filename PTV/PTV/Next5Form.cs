using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTV
{
    public partial class Next5Form : Form
    {
        ManualResetEvent getResult = new ManualResetEvent(false);

        public Next5Form()
        {
            InitializeComponent();
        }

        private void StopSearchBox_TextChanged(object sender, EventArgs e)
        {
            //
            
            //Console.WriteLine("key typed");
            //1. Get the serach string
            string searchQuery = stopSearchBox.Text.ToString();
            //2. Get the stop list from Search Model

            Thread t = new Thread(async () => 
            {
                dynamic search_result = await Search.GetSearchResult(searchQuery);
                //Console.WriteLine(search_result);
                Action action = new Action( ()=> Display_Search_Result(search_result));
                this.BeginInvoke(action);
                //Display_Search_Result(search_result);
            });
            t.Start();
            //3. Display the stops in the listed form by using a function
             
            
            //4. Get the stop id of the selected stop.

            //5. 

        }

        private void Display_Search_Result(dynamic result)
        {
            //Console.WriteLine("called");
            //Console.WriteLine(result);
            if(result.stops.Count ==0)
            {
                //print no stops found
                Console.WriteLine("0 results");
            }
            else
            {

                //stopSearchBox.AutoCompleteCustomSource.Clear();
                AutoCompleteStringCollection resultList = new AutoCompleteStringCollection();
                
                foreach (dynamic stop in result.stops)
                {
                    //if(stop.route_type.Value==0)
                        resultList.Add(stop.stop_name.Value);
                }
                stopSearchBox.AutoCompleteCustomSource = resultList;
                //stopSearchBox.AutoCompleteMode = AutoCompleteMode.Suggest;

               /* int cnt = 0;
                foreach (dynamic stop in result.stops)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = stop.stop_name;

                    if (stop.route_type == 0)
                        item.BackColor = Color.LightBlue;
                    else if (stop.route_type == 1)
                        item.BackColor = Color.LightGreen;
                    else if (stop.route_type == 2)
                        item.BackColor = Color.Orange;
                    else if (stop.route_type == 3)
                        item.BackColor = Color.MediumPurple;
                    else if (stop.route_type == 4)
                        item.BackColor = Color.Purple;

                    item.Position = new Point(0, 0 + cnt * 30);
                    
                    //item.BorderStyle = BorderStyle.FixedSingle;
                    //item.Visible = true;

                    //searchResultPanel.Controls.Add(item);
                    //searchResultPanel.Items.Add(item);
                    //searchResultPanel.Size = new Size(searchResultPanel.Size.Width, searchResultPanel.Size.Height + 30);
                    //searchResultPanel.Visible = true;
                 }*/

            }
        }

    }

    
}

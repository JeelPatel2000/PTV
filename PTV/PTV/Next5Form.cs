﻿using System;
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


        private void Display_Search_Result(dynamic result)
        {
            //Console.WriteLine("called");
            //Console.WriteLine(result);
            if(result.stops.Count ==0)
            {
                //print no stops found
                //Console.WriteLine("0 results");
                Clear_Search_Results_Panel();
            }
            else
            {

                Clear_Search_Results_Panel();

                int cnt = 0;
                foreach (dynamic stop in result.stops)
                {

                    if (stop.route_type.Value == 0)
                    {
                        Button item = new Button();
                        //item.Parent = searchResultListPanel;
                        searchResultListPanel.Controls.Add(item);

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

                        item.Parent = searchResultListPanel;
                        item.Width = searchResultListPanel.Width;
                        item.Height = 40;
                        item.Location = new Point(0, cnt * 40);
                        item.Font = new Font(FontFamily.GenericSansSerif, 12);
                        item.TabIndex = 5;

                        item.Click += (sender, e) => { stopClickedEvent(sender, e, stop.stop_id.ToString(), stop.stop_name.ToString()); };
                        
                        

                        searchResultListPanel.Height = (cnt + 1) * 40;

                        cnt++;

                        if (cnt == 10) break;
                    }
                }
                

                
            }
        }

        
        public void stopClickedEvent(object sender,EventArgs e,string stop_id,string stop_name)
        {
            stopSearchBox.Text = stop_name;
            Clear_Search_Results_Panel();
            
            //displaying the departures
            Display_Next_Departures(Int32.Parse(stop_id));
        }

        public async Task Display_Next_Departures(int stop_id)
        {
            dynamic departures = await Departures.GetDepartures(stop_id);
            Console.WriteLine(departures);           

        }

        public void Clear_Search_Results_Panel()
        {
            searchResultListPanel.Controls.Clear();
            searchResultListPanel.Height = 0;
        }

        private void StopSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            string searchQuery = stopSearchBox.Text;

            if (searchQuery.Length != 0)
            {
                Thread t = new Thread(async () =>
                {
                    dynamic search_result = await Search.GetSearchResult(searchQuery);
                    //Console.WriteLine(search_result);
                    Action action = new Action(() => Display_Search_Result(search_result));
                    this.BeginInvoke(action);
                    //Display_Search_Result(search_result);
                });
                t.Start();
            }
        }

    }

    
}

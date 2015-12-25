using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace CombatAnalyzer
{
    class ListViewItemComparer : IComparer
    {
        private int col;
        private bool asc = true;

        public bool Ascending
        {
            get { return asc; }
        }

        public ListViewItemComparer()
        {
            col = 0;
            asc = true;
        }
        public ListViewItemComparer(int column)
        {
            col = column;
            asc = true;
        }
        public ListViewItemComparer(int column, bool ascending)
        {
            col = column;
            asc = ascending;
        }


        public int Compare(object x, object y)
        {
            ListViewItem item1 = (ListViewItem)x;
            ListViewItem item2 = (ListViewItem)y;

            if (col == 0)
            {
                if (asc)
                    return String.Compare(item1.Text, item2.Text);
                else
                    return (String.Compare(item1.Text, item2.Text) * -1);
            }
            else
            {
                if (asc)
                {
                    if (Convert.ToInt32(item1.SubItems[col].Text) < Convert.ToInt32(item2.SubItems[col].Text)) return -1;
                    if (Convert.ToInt32(item1.SubItems[col].Text) > Convert.ToInt32(item2.SubItems[col].Text)) return 1;
                }
                else
                {
                    if (Convert.ToInt32(item1.SubItems[col].Text) < Convert.ToInt32(item2.SubItems[col].Text)) return 1;
                    if (Convert.ToInt32(item1.SubItems[col].Text) > Convert.ToInt32(item2.SubItems[col].Text)) return -1;
                }

                return 0;
            }
        }
    }
}

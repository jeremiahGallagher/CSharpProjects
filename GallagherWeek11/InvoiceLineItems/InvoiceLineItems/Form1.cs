using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceLineItems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<LineItem> lineItemList = LineItemDB.GetLineItems();
            List<Invoice> invoiceList = InvoiceDB.GetInvoices();

            var lineItems = from lineItem in lineItemList
                            join invoice in invoiceList
                            on lineItem.InvoiceID equals invoice.InvoiceID
                            orderby invoice.InvoiceDate
                            select new
                            {
                                invoice.InvoiceID,
                                invoice.InvoiceDate,
                                invoice.InvoiceTotal,
                                lineItem.ProductCode,
                                lineItem.UnitPrice,
                                lineItem.Quantity,
                                lineItem.ItemTotal
                            };
            int invoiceID = 0;
            int i = 0;

            foreach ( var lineItem in lineItems)
            {
                if (lineItem.InvoiceID != invoiceID)
                {
                    listView1.Items.Add(lineItem.InvoiceID.ToString());
                    invoiceID = lineItem.InvoiceID;
                }
                else
                {
                    listView1.Items.Add("");
                }
                listView1.Items[i].SubItems.Add(lineItem.InvoiceID.ToString());
                listView1.Items[i].SubItems.Add(Convert.ToDateTime(lineItem.InvoiceDate).ToShortDateString());
                listView1.Items[i].SubItems.Add(lineItem.InvoiceTotal.ToString("c"));
                listView1.Items[i].SubItems.Add(lineItem.ProductCode);
                listView1.Items[i].SubItems.Add(lineItem.UnitPrice.ToString("c"));
                listView1.Items[i].SubItems.Add(lineItem.Quantity.ToString());
                listView1.Items[i].SubItems.Add(lineItem.ItemTotal.ToString("c"));
                i += 1;
            }
                                                
        }
    }
}

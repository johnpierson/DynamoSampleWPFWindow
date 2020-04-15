using System;
using System.Collections.Generic;
using DynamoWPFSample.UI;
using Application = System.Windows.Application;

namespace DynamoWPFSample
{
    /// <summary>
    /// Wrapper class for selection
    /// </summary>
    public class Selection
    {
        private Selection()
        {
        }

        /// <summary>
        /// This provides a window to pick items from a list. It outputs them in ordered selection.
        /// </summary>
        /// <param name="list"></param>
        /// <returns name="selectedItems"></returns>
        public static List<Object> PickItemsFromList(List<Object> list)
        {

            //our list to return as the output
            List<Object> returnList = new List<object>();
           
            //this forces the window to load on the UI thread. Important because Dynamo Sandbox is Multi-Threaded
            Application.Current.Dispatcher.Invoke(new Action(() =>
            {
                //construct the sample window and show it
                SampleWindow window = new SampleWindow(list);

                //we show this as modal so that way we can return the  selected items
                window.ShowDialog();

                //iterate through the list box and add the items to our return list
                foreach (var item in window.SelectionList.SelectedItems)
                {
                    returnList.Add(item);
                }

            }));

            return returnList;
        }
    }
}

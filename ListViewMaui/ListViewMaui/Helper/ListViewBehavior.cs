using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Syncfusion.Maui.ListView.Helpers;
using Syncfusion.Maui.DataSource;
using Syncfusion.Maui.ListView;
using Syncfusion.Maui.DataSource.Extensions;

namespace ListViewMaui
{
    #region ListViewBehavior
    public class ListViewBehavior : Behavior<SfListView>
    {
        #region Fields

        private SfListView ListView;
        private GroupResult expandedGroup;

        #endregion

        #region Overrides
        protected override void OnAttachedTo(SfListView bindable)
        {
            ListView = bindable;
            ListView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
            {
                PropertyName = "ContactName",
                KeySelector = (object obj1) =>
                {
                    var item = (obj1 as ListViewContactInfo);
                    return item.ContactName[0].ToString();
                },
            });
            ListView.Loaded += ListView_Loaded;
            ListView.GroupExpanding += ListView_GroupExpanding;
            base.OnAttachedTo(bindable);
            var obj = new object();
        }

        protected override void OnDetachingFrom(SfListView bindable)
        {
            ListView.Loaded -= ListView_Loaded;
            ListView.GroupExpanding -= ListView_GroupExpanding;
            ListView = null;
            expandedGroup = null;
            base.OnDetachingFrom(bindable);
        }
        #endregion

        #region Callbacks

        private void ListView_Loaded(object sender, EventArgs e)
        {
            this.Dispatcher.Dispatch(() =>
            {
                ListView.CollapseAll();
                var group = ListView.DataSource.Groups[0];
                ListView.ExpandGroup(group);
            });
        }

        private void ListView_GroupExpanding(object sender, GroupExpandCollapseChangingEventArgs e)
        {
            if (e.Groups.Count > 0)
            {
                var currentGroup = e.Groups[0];

                if (expandedGroup != null && expandedGroup.Key != currentGroup.Key)
                {
                    ListView.CollapseGroup(expandedGroup);
                }
                expandedGroup = currentGroup;
            }
        }
        #endregion
    }

    #endregion
}

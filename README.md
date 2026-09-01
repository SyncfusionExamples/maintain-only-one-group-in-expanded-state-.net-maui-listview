# How to maintain only one group in the expanded state in .NET MAUI ListView (SfListView)?

In [.NET MAUI ListView (SfListView)](https://www.syncfusion.com/maui-controls/maui-listview) you can ensure only one group remains in an expanded state by handling the [GroupExpanding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupExpanding) event. This approach involves collapsing all other groups when a new group is expanded, maintaining a cleaner and more organized view.

Manually expand the first group in the [Loaded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_Loaded) event. In the GroupExpanding event, compare the current expanded group with the previous one and collapse the previous expanded group.

![Maintain only one group in expanded state in .NET MAUI ListView (SfListView)](https://www.syncfusion.com/uploads/user/kb/maui/maui-2096/maui-2096_img1.gif)

Download the complete sample on [GitHub](https://github.com/SyncfusionExamples/maintain-only-one-group-in-expanded-state-.net-maui-listview).

**Conclusion**

I hope you enjoyed learning how to maintain only one group in the expanded state in .NET MAUI ListView.

You can refer to our [.NET MAUI ListView feature tour](https://www.syncfusion.com/maui-controls/maui-listview) page to learn about its other groundbreaking feature representations and [documentation](https://help.syncfusion.com/maui/listview/getting-started), and how to quickly get started with configuration specifications. Explore our [.NET MAUI ListView example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/ListView) to understand how to create and manipulate data.

For current customers, check out our components from the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion®, try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to check out our other controls.

Please let us know in the comments section if you have any queries or require clarification. Contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create), or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sflistview). We are always happy to assist you!

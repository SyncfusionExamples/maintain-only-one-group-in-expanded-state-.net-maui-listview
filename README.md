**[View document in Syncfusion .NET MAUI Knowledge Base](https://www.syncfusion.com/kb/13181/how-to-maintain-only-one-group-in-the-expanded-state-in-net-maui-listview-sflistview)**

## Sample

```xaml
<ListView:SfListView x:Name="listView"
                        ItemSize="70" 
                        GroupHeaderSize="50"
                        SelectionMode="Single"
                        IsStickyGroupHeader="True"
                        ItemsSource="{Binding ContactsInfo}"
                        AllowGroupExpandCollapse="True">

    <ListView:SfListView.GroupHeaderTemplate>
        <DataTemplate>
            <StackLayout BackgroundColor="#E4E4E4">
                <Label Text="{Binding Key}" FontSize="20" FontAttributes="Bold" TextColor="#4d4d4d" Padding="10,0,0,0" VerticalOptions="Center" HorizontalOptions="Start"/>
            </StackLayout>
        </DataTemplate>
    </ListView:SfListView.GroupHeaderTemplate>
    
    <ListView:SfListView.ItemTemplate>
        <DataTemplate>
            <code>
            . . .
            . . .
            <code>
        </DataTemplate>
    </ListView:SfListView.ItemTemplate>
</ListView:SfListView>

C#:

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
```
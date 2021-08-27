<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1097)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MyEvent.cs](./CS/DXExample.Module/MyEvent.cs) (VB: [MyEvent.vb](./VB/DXExample.Module/MyEvent.vb))
* **[MyUser.cs](./CS/DXExample.Module/MyUser.cs) (VB: [MyUser.vb](./VB/DXExample.Module/MyUser.vb))**
* [Updater.cs](./CS/DXExample.Module/Updater.cs) (VB: [Updater.vb](./VB/DXExample.Module/Updater.vb))
<!-- default file list end -->
# OBSOLETE - How to use users as resources for Scheduler


<p><strong>============================</strong><strong><br />
</strong><strong>T</strong><strong>his example will not be maintained any longer, since a similar approach is demonstrated in the </strong><a href="https://www.devexpress.com/Support/Center/p/E1255">How to create fully custom Role, User, Event, Resource classes for use with the Security and Scheduler modules</a><strong> example. Please refer to that example and see how the IResource interface is implemented in its Employee class. </strong><strong><br />
============================</strong></p><p><br />
This example demonstrates how to share scheduler events between users when using the Complex Security. For that purpose, the IResource interface will be implemented by the custom user class (User class descendant), and the custom event class will be used.</p><p><strong>See Also:</strong><br />
<a href="http://documentation.devexpress.com/#Xaf/CustomDocument2813"><u>Resources in a Schedule</u></a></p>


<h3>Description</h3>

<p>The implementation of the MyEvent.UpdateResourceIds method was changed.</p>

<br/>



# OBSOLETE - How to use users as resources for Scheduler


<p><strong>============================</strong><strong><br />
</strong><strong>T</strong><strong>his example will not be maintained any longer, since a similar approach is demonstrated in the </strong><a href="https://www.devexpress.com/Support/Center/p/E1255">How to create fully custom Role, User, Event, Resource classes for use with the Security and Scheduler modules</a><strong> example. Please refer to that example and see how the IResource interface is implemented in its Employee class. </strong><strong><br />
============================</strong></p><p><br />
This example demonstrates how to share scheduler events between users when using the Complex Security. For that purpose, the IResource interface will be implemented by the custom user class (User class descendant), and the custom event class will be used.</p><p><strong>See Also:</strong><br />
<a href="http://documentation.devexpress.com/#Xaf/CustomDocument2813"><u>Resources in a Schedule</u></a></p>


<h3>Description</h3>

<p>The implementation of the MyEvent.UpdateResourceIds method was changed.</p>

<br/>



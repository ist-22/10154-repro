using Lib1;

namespace app;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);

        (FindViewById(Resource.Id.textView) as TextView).Text = "Random: " + new Lib1Class().ReturnRandomValueFromLib2();
    }
}
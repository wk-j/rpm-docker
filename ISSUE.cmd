> /usr/share/my-web/MyWeb

FailFast:
Couldn't find a valid ICU package installed on the system. Set the configuration flag System.Globalization.Invari
ant to true if you want to run with no globalization support.

   at System.Environment.FailFast(System.String)
   at System.Globalization.GlobalizationMode.GetGlobalizationInvariantMode()
   at System.Globalization.GlobalizationMode..cctor()
   at System.Globalization.CultureData.CreateCultureWithInvariantData()
   at System.Globalization.CultureData.get_Invariant()
   at System.Globalization.CultureInfo..cctor()
   at System.StringComparer..cctor()
   at System.AppDomain.InitializeCompatibilityFlags()
   at System.AppDomain.Setup(System.Object)
Aborted


> systemctl enable MyWeb
> systemctl start MyWeb
Failed to get D-Bus connection: Operation not permitted
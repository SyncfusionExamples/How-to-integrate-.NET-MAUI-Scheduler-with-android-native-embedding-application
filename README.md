# How to integrate .NET MAUI Scheduler with android native embedding application

This repository contains the sample code to integrate [SfScheduler](https://help.syncfusion.com/maui/scheduler/getting-started) with the android native embedding application.

## Syncfusion controls

This project used the following Syncfusion control(s):
* [.NET MAUI Scheduler (SfScheduler)](https://www.syncfusion.com/maui-controls/maui-scheduler)

## Supported platforms

| Platforms | Supported versions |
| --------- | ------------------ |
| Android   | API level 19 and later versions |

## Requirements to run the sample

* [Visual Studio](https://visualstudio.microsoft.com/downloads/)
* [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac)

Refer to the following link for more details: [System Requirements](https://help.syncfusion.com/maui/system-requirements)

## How to run the sample

1. Clone the sample and open it in Visual Studio 2022 preview.
   
   *Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.*

2. Register your license key in the App.cs file as demonstrated in the following code.

		public App()
		{
			//Register Syncfusion license
			Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");
		
			InitializeComponent();
		
			MainPage = new MainPage();
		}
		
	Refer to this [link](https://help.syncfusion.com/maui/licensing/overview) for more details.
	
3. Clean and build the application.

4. Run the application.

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
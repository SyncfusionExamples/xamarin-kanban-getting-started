# Xamarin.iOS Kanban Getting Started
This example provides you an overview for working with SfKanban for Xamarin.Forms and also provides a walk through to configure SfKanban control in real time scenario.The Kanban control is an efficient way to visualize a workflow at each stage of completion.

For know more about kanban : https://www.syncfusion.com/xamarin-ios-ui-controls/kanban-board

Kanban user guide documentation : https://help.syncfusion.com/xamarin-ios/sfkanban/overview

## Supported platforms

| Platforms | Supported versions |
| --------- | ------------------ |
| iOS   | iOS 9.0 and later versions |

## Requirements to run the sample

* [Visual Studio](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)

Refer to the following link for more details - [System Requirements](https://help.syncfusion.com/xamarin-ios/system-requirements)

## How to run the sample

1. Clone the sample and open it in Visual Studio.

   *Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.*

2. Register your license key in the App.xaml.cs file as demonstrated in the following code.

		public App()
		{
			//Register Syncfusion license
			Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

			InitializeComponent();

			MainPage = new App1.MainPage();
		}
		
	Refer to this [link](https://help.syncfusion.com/xamarin/licensing/overview) for more details.

3. Clean and build the application.

4. Run the application.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
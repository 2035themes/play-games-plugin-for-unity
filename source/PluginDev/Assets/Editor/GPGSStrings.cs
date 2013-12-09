﻿/*
 * Copyright (C) 2013 Google Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;

public class GPGSStrings {
    public const string Error = "Error";
    public const string Ok = "OK";
    public const string Cancel = "Cancel";
    public const string Yes = "Yes";
    public const string No = "No";
    public const string Success = "Success";

    public class Setup {
        public const string AppIdTitle = "Google Play Games Application ID";
        public const string AppId = "Application ID";
        public const string AppIdBlurb = "Enter your application ID below. This is the numeric\n" +
            "identifier provided by the Developer Console (for example, 123456789012).";
        public const string AppIdError = "The App Id does not appear to be valid. " +
            "It must consist solely of digits, usually 10 or more.";
        public const string SetupButton = "Setup";
    }

    public class IOSSetup {
        public const string Title = "Google Play Games - iOS Setup";
        public const string Blurb = "To configure Google Play Games for iOS in this project,\n" +
            "please enter the information below and click on the Setup button.";
        public const string ClientIdTitle = "Oauth Client ID";
        public const string ClientId = "Client ID";
        public const string ClientIdBlurb = "Enter your oauth2 client ID below. To obtain this\n" +
            "ID, generate an iOS linked app in Developer Console. Example:\n" +
            "123456789012-jafwiawoijjfe.apps.googleusercontent.com";
        public const string ClientIdError = "The Client ID does not appear to be valid. " +
            "It should end in .apps.googleusercontent.com.";
        public const string BundleIdTitle = "Bundle Identifier";
        public const string BundleId = "Bundle ID";
        public const string BundleIdBlurb = "Enter your application's bundle identifier below.\n" +
            "(for example, com.example.lorem.ipsum).";
        public const string BundleIdError = "The bundle ID does not appear to be valid.";
        public const string SetupComplete = "Setup complete. Ready for iOS build.";
    }

    public class AndroidSetup {
        public const string Title = "Google Play Games - Android Configuration";
        public const string Blurb = "To configure Google Play Games in this project,\n" +
            "please enter the information below and click on the Setup button.";
        public const string PkgName = "Package name";
        public const string PkgNameBlurb = "Enter your application's package name below.\n" +
            "(for example, com.example.lorem.ipsum).";

        public const string PackageNameError = "The package name does not appear to be valid. " +
            "Enter a valid Android package name (for example, com.example.lorem.ipsum).";

        public const string SdkNotFound = "Android SDK Not found";
        public const string SdkNotFoundBlurb = "The Android SDK path was not found. " +
                "Please configure it in the Unity preferences window (under External Tools).";

        public const string LibProjNotFound = "Google Play Services Library Project Not Found";
        public const string LibProjNotFoundBlurb = "Google Play Services library project " +
                "could not be found your SDK installation. Make sure it is installed (open " +
                "the SDK manager and go to Extras, and select Google Play Services).";

        public const string SetupComplete = "Google Play Games configured successfully. " +
            "\n\nNote: remember to set the minimum Android version to Froyo (2.2) or above on the " +
            "Build Settings window before building.";
    }

    public class ExternalLinks {
        public const string GettingStartedGuideURL =
            "https://github.com/playgameservices/play-games-unity-plugin";
        public const string PlayGamesServicesApiURL =
            "https://developers.google.com/games/services";

        public const string GooglePlusSdkTitle = "Google+ SDK Download";
        public const string GooglePlusSdkBlurb = "You will be taken to the download site for " +
            "the Google+ for iOS SDK. This is only necessary for iOS builds. Once you are " +
            "on that page, download the item named 'Google+ iOS SDK'.";
        public const string GooglePlusSdkUrl =
            "https://developers.google.com/+/downloads/";

        public const string GooglePlayGamesSdkTitle = "Google Play Games SDK Download";
        public const string GooglePlayGamesSdkBlurb = "You will be taken to the download site for " +
            "the Google Play Games SDK for iOS. This is only necessary for iOS builds. " +
            "Once you are on that page, download the item named 'Games SDK Version X.Y.Z'.";
        public const string GooglePlayGamesUrl =
            "https://developers.google.com/games/services/downloads/";

        public const string GooglePlayGamesAndroidSdkTitle = "Google Play Games Android SDK Download";
        public const string GooglePlayGamesAndroidSdkBlurb = "The Google Play Games SDK for " +
            "Android must be downloaded via the Android SDK Manager. Do you wish to " +
            "start the SDK manager now?";
        public const string GooglePlayGamesAndroidSdkInstructions = "The Android SDK manager " +
            "will be launched. Install or upgrade the 'Google Play Services' package, " +
            "which can be found under the 'Extras' " +
            "category.";
        public const string GooglePlayGamesAndroidSdkManagerFailed = "Failed to find the " +
            "Android SDK manager executable. Make sure the Android SDK is properly installed " +
            "and that its path is correctly configured in the Unity preferences window " +
            "(under External Tools).";
    }
    
    public const string AboutTitle = "Google Play Games Plugin for Unity";
    public const string AboutText = "Copyright (C) 2013 Google Inc.\n\nThis is an open-source " +
            "plugin that allows cross-platform integration with Google Play games services. " + 
            "For more information, visit the official site on Github:\n\n" +
            "https://github.com/playgameservices/play-games-unity-plugin\n\nPlugin version: ";
            
    public const string LicenseTitle = "Google Play Games Plugin for Unity";
    public const string LicenseText = "Copyright (C) 2013 Google Inc.\n\n" +
            "Licensed under the Apache License, Version 2.0 (the \"License\"); " +
            "you may not use this file except in compliance with the License. " +
            "You may obtain a copy of the License at\n\n" +
            "      http://www.apache.org/licenses/LICENSE-2.0\n\n" +
            "Unless required by applicable law or agreed to in writing, software " +
            "distributed under the License is distributed on an \"AS IS\" BASIS, " +
            "WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. " +
            "See the License for the specific language governing permissions and " +
            "limitations under the License.";
}

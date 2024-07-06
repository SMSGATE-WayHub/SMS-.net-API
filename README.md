SMS Gateway Hub Client (C#)
==========================

This is a C# client for sending SMS using the SMS Gateway Hub API.

**Prerequisites**

* A valid API key from SMS Gateway Hub
* A valid sender ID from SMS Gateway Hub
* A registered entity ID from SMS Gateway Hub (optional)
* A registered DLT template ID from SMS Gateway Hub (optional)

**Usage**

1. Replace `YourAPIkey` with your actual API key from SMS Gateway Hub.
2. Replace `TESTIN` with your actual sender ID from SMS Gateway Hub.
3. Replace `YOUR MESSAGE HERE` with the message you want to send.
4. Replace `91989xxxxxxx` with the mobile number you want to send the SMS to. You can add multiple numbers separated by commas.
5. Replace `Registered-Entity-Id` with your actual registered entity ID from SMS Gateway Hub (optional).
6. Replace `Registered-DLT-Template-Id` with your actual registered DLT template ID from SMS Gateway Hub (optional).
7. Compile and run the C# program.

**API Endpoint**

The API endpoint is a GET request to: https://www.smsgatewayhub.com/api/mt/SendSMS

**Query Parameters**

The query parameters are:

* `APIKey`: Your API key from SMS Gateway Hub.
* `senderid`: Your sender ID from SMS Gateway Hub.
* `channel`: The channel to use for sending the SMS (default is 2).
* `DCS`: The data coding scheme to use for sending the SMS (default is 0).
* `flashsms`: Whether to send the SMS as a flash SMS (default is 0).
* `number`: The mobile number to send the SMS to.
* `text`: The text of the SMS to be sent.
* `route`: The route to use for sending the SMS (optional).
* `EntityId`: The registered entity ID from SMS Gateway Hub (optional).
* `dlttemplateid`: The registered DLT template ID from SMS Gateway Hub (optional).

**Example Output**

The program will print the response from the API to the console. If the API call is successful, it will print the response body. If the API call fails, it will print an error message with the status code.

**Note**

* Make sure to replace the placeholders with your actual values.
* This program assumes that you have a valid API key and sender ID from SMS Gateway Hub.
* This program sends a single SMS to a single mobile number. If you want to send SMS to multiple numbers, you'll need to modify the program accordingly.

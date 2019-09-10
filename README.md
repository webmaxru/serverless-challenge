# Azure Functions Code Challenge
## Want an awesome Azure IoT DevKit? Time to code!

Do you want to get an [Azure IoT DevKit](https://microsoft.github.io/azure-iot-developer-kit/) and learn about Azure Functions? Then you only need 5 minutes and a browser to play our code challenge! Ready? Let's start!

![Azure IoT DevKit](https://github.com/webmaxru/serverless-challenge/blob/master/images/devkit.jpg)

## What is Azure Functions?
Azure Functions is a solution for easily running small pieces of code, or "functions," in the cloud. You can write just the code you need for the problem at hand, without worrying about a whole application or the infrastructure to run it. Functions can make development even more productive, and you can use your development language of choice, such as C#, F#, Node.js, Java, or PHP. Pay only for the time your code runs and trust Azure to scale as needed. Azure Functions lets you develop serverless applications on Microsoft Azure. Want to learn more? You can read here an [Introduction to Azure Functions.](https://docs.microsoft.com/en-us/azure/azure-functions/functions-overview)

## The challenge!
**You have to deploy a new Azure Function in C#.** This function will open a web page that will redirect you to the registration page. Once you register, you will receive a confirmation email. You only need to come to the Microsoft booth and ask for your t-shirt showing your confirmation email. That's all!

## So do I need to code?
Not really... you just need to copy and paste the [code found here](https://github.com/webmaxru/serverless-challenge/blob/master/index.js)  when creating your Azure Function. It will take you only a few minutes!

# STEP 1 - Create your function in the Azure Portal

Azure Functions lets you execute your code in a serverless environment without having to first create a VM or publish a web application. You will learn how to use Functions to create a function in the Azure portal.

**If you don't have an [Azure subscription](https://docs.microsoft.com/azure/guides/developer/azure-developer-guide#understanding-accounts-subscriptions-and-billing), create a [free account](https://azure.microsoft.com/free/?ref=microsoft.com&utm_source=microsoft.com&utm_medium=docs&utm_campaign=visualstudio) before you begin.**

## Log in to Azure

Sign in to the Azure portal at https://portal.azure.com with your Azure account.
Create a function app

You must have a function app to host the execution of your functions. A function app lets you group functions as a logic unit for easier management, deployment, and sharing of resources.

1. Select the **Create a resource** button found on the upper left-hand corner of the Azure portal, then select **Compute > Function App**.

![Create Resource](https://github.com/webmaxru/serverless-challenge/blob/master/images/pic-1.PNG)

2. Use the function app settings as specified in the table below the image.

![Create Function](https://github.com/webmaxru/serverless-challenge/blob/master/images/pic-2.PNG)

Setting | Suggested value |	Description
------- | --------------- | -----------
App name | Globally unique name | Name that identifies your new function app. Valid characters are a-z, 0-9, and -. **Enter a descriptive name, for example YOURNAMEserverless-challenge**
Subscription | Your subscription | The subscription under which this new function app is created. **Select your active Subscription, or FREE TRIAL if you are using a trial**
Resource Group | myResourceGroup | Name for the new resource group in which to create your function app. **Enter YOURNAMEserverless-challenge**
OS | Windows | Serverless hosting on Linux is currently in preview. For more information, see this considerations article. **Select WINDOWS**
Hosting plan | Consumption plan | Hosting plan that defines how resources are allocated to your function app. In the default Consumption Plan, resources are added dynamically as required by your functions. In this serverless hosting, you only pay for the time your functions run. When you run in an App Service plan, you must manage the scaling of your function app. **Choose Consumption Plan**
Location | North Europe | Choose a region near you or near other services your functions access. **Choose North Europe**
Runtime stack | Preferred language | Choose a runtime that supports your favorite function programming language. **Choose Node.js**
Storage | Globally unique name | Create a storage account used by your function app. Storage account names must be between 3 and 24 characters in length and may contain numbers and lowercase letters only. You can also use an existing account, which must meets the storage account requirements. **Choose Create new and choose the default name generated.**
Application Insights | Default | Creates an Application Insights resource of the same App name in the nearest supported region. By expanding this setting, you can change the New resource name or choose a different Location in an Azure geography where you want to store your data. **Choose Default**

3. Select **Create** to provision and deploy the function app.

4. Select the Notification icon in the upper-right corner of the portal and watch for the **Deployment succeeded** message.

![Show notifications](https://docs.microsoft.com/en-us/azure/includes/media/functions-create-function-app-portal/function-app-create-notification.png)

5. Select **Go to resource** to view your new function app. You can also select **Pin to dashboard**. Pinning makes it easier to return to this function app resource from your dashboard.

Next, you create a function in the new function app.

# STEP 2 - Create an HTTP triggered function

1. Expand your new function app, then select the + button next to **Functions**, choose **In-portal**, and select **Continue**.

![Create in portal http triggered](https://github.com/webmaxru/serverless-challenge/blob/master/images/pic-4.PNG)

2. Choose **WebHook + API** and then select **Create**.

![Create in portal http webhook api](https://github.com/webmaxru/serverless-challenge/blob/master/images/pic-5.PNG)

3. A function  is created using a language-specific template for an HTTP triggered function. Now, copy the content of [this file](https://github.com/webmaxru/serverless-challenge/blob/master/index.js) and paste it into the textbox.

4. Click on **Save**.

5. Your function is ready! Now, you should click on **</>Get Function URL** and click on **Copy to clipboard**.

![Cut and paste URL](https://github.com/webmaxru/serverless-challenge/blob/master/images/pic-6.PNG)

6. **This is the URL you have to paste in any browser.** After one second, the page will redirect automatically to a registration page. Fill the form and you will receive a confirmation email.

7. You are done! Now you have to visit us in our booth, show us the confirmation email and get your t-shirt!


using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace SeleniumMSFlow
{
    public static class Base
    {
        public static bool ElementVanished(IWebDriver driver, string by, int timer = 5000)
        {
            try
            {
                DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
                wait.PollingInterval = TimeSpan.FromMilliseconds(timer / 10);
                wait.Timeout = TimeSpan.FromMilliseconds(timer);
                wait.Until(de => de.FindElements(By.XPath(by)).Count == 0);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void WaitUntilUrlChanges(IWebDriver driver, string url, int timer = 5000)
        {
            try
            {
                DefaultWait<IWebDriver> wait = new(driver);
                wait.PollingInterval = TimeSpan.FromMilliseconds(timer / 5);
                wait.Timeout = TimeSpan.FromMilliseconds(timer);
                wait.Until(dr => dr.Url != url);

            }
            catch
            {

            }
        }

        public static void ClickToElement(IWebDriver driver, string by, string error = "Object not found", int timer = 5000)
        {
            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.Timeout = TimeSpan.FromMilliseconds(timer);
            wait.PollingInterval = TimeSpan.FromMilliseconds(timer / 5);
            Actions action = new Actions(driver);
            IWebElement element;
            try
            {
                wait.Until(de => de.FindElements(By.XPath(by)).Count > 0);
                element = driver.FindElement(By.XPath(by));
                action.MoveToElement(element).Perform();
                action.Click(element).Perform();
            }
            catch
            {
                throw new Exception(error);
            }
        }

        public static IWebElement FindElement(IWebDriver driver, string by, string error = "Object Not Found", int timer = 5000)
        {
            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.Timeout = TimeSpan.FromMilliseconds(timer);
            Actions action = new Actions(driver);
            IWebElement elemen;
            try
            {
                wait.Until(de => de.FindElements(By.XPath(by)).Count > 0);
                elemen = driver.FindElement(By.XPath(by));
                action.MoveToElement(elemen).Perform();
                return elemen;
            }
            catch
            {
                throw new Exception(error);
            }

        }

        public static void SendKeys(IWebDriver driver, string by, string text, string error = "Object not found", int timer = 5000)
        {
            try
            {
                ClearField(driver, by, error, timer);
                FindElement(driver, by, error, timer).SendKeys(text);
            }
            catch
            {
                throw new Exception(error);
            }
        }

        public static void ClearField(IWebDriver driver, string XPath, string error = "Object not found", int timer = 5000) => FindElement(driver, XPath, error, timer: timer).Clear();

        public static bool ElementExists(IWebDriver driver, string by, int timer = 5000)
        {
            try
            {
                DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
                wait.PollingInterval = TimeSpan.FromMilliseconds(timer / 5);
                wait.Timeout = TimeSpan.FromMilliseconds(timer);
                wait.Until(de => de.FindElements(By.XPath(by)).Count > 0);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void DragAndDrop(IWebDriver driver, string from, string to, string error = "Object not found", double timer = 4)
        {
            Actions actions = new(driver);
            DefaultWait<IWebDriver> wait = new(driver);
            wait.Timeout = TimeSpan.FromSeconds(timer);

            try
            {
                wait.Until(de => de.FindElements(By.XPath(from)).Count > 0);
                IWebElement source = FindElement(driver, from);

                IWebElement target = FindElement(driver, to);

                actions.DragAndDrop(source, target).Perform();
            }
            catch
            {
                throw new Exception(error);
            }
        }

        public static void FinishTest(IWebDriver driver)
        {
            driver.Close();
            driver.Dispose();
        }
        public static void Scroll(IWebDriver driver, int by = 500)
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript($"window.scrollBy(0,{by});");
        }


        public static void GoToUrl(IWebDriver driver, string url) => driver.Navigate().GoToUrl(url);

        public static string GetTextContent(IWebDriver driver, string element)
        {
            IWebElement webElement = FindElement(driver, element);
            IJavaScriptExecutor executor = driver as IJavaScriptExecutor;
            if (executor == null || webElement == null)
            {
                return string.Empty;    //returns empty string
            }
            else
            {
                return executor.ExecuteScript("return arguments[0].textContent;", webElement).ToString().Trim();
            }
        }

        public static bool ElementVisible(IWebDriver driver, string by, string error = "Object Not Found")
        {
            try
            {
                return driver.FindElement(By.XPath(by)).Displayed;
            }
            catch (Exception)
            {
                throw new Exception(error);
            }
        }

        public static void WaitUntilElementVanishes(IWebDriver driver, string element, int timer = 5000)
        {
            try
            {
                DefaultWait<IWebDriver> wait = new(driver);
                wait.PollingInterval = TimeSpan.FromMilliseconds(100);
                wait.Timeout = TimeSpan.FromMilliseconds(timer);
                wait.Until(de => de.FindElements(By.XPath(element)).Count == 0);
            }
            catch (Exception)
            {
            }
        }

        public static ReadOnlyCollection<IWebElement> FindElements(IWebDriver driver, string by) => driver.FindElements(By.XPath(by));

        public static void SafeClickToElement(IWebDriver driver, string by, int timer = 5000)
        {
            DefaultWait<IWebDriver> wait = new(driver);
            wait.Timeout = TimeSpan.FromMilliseconds(timer);
            wait.PollingInterval = TimeSpan.FromMilliseconds(timer / 5);
            Actions action = new(driver);
            IWebElement element;
            try
            {
                wait.Until(de => de.FindElements(By.XPath(by)).Count > 0);
                wait.Until(ExpectedConditions.ElementToBeClickable(FindElement(driver, by, timer: timer)));
                element = driver.FindElement(By.XPath(by));
                action.MoveToElement(element).Perform();
                action.Click(element).Perform();
            }
            catch
            {
            }
        }

        public static void OpenNewTab(IWebDriver driver, string url)
        {
            _ = ((IJavaScriptExecutor)driver).ExecuteScript(string.Format($"window.open('{url}', '_blank');"));
            driver.SwitchTo().Window(driver.WindowHandles[1]);
        }
        public static void CloseTab(IWebDriver driver)
        {
            //((IJavaScriptExecutor)driver).ExecuteScript(string.Format("window.close();"));
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }


        public static void WaitUntilVisible(WebDriverWait wait, string element)
        {
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(element)));
            }
            catch
            {
                throw new Exception($"{element} - Element Isn't Visible!");
            }
        }

        public static void Reload(IWebDriver driver) => driver.Navigate().Refresh();

        public static void HardReload(IWebDriver driver)
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("location.reload(true);");
        }

        public static void MaximizeWindow(IWebDriver driver) => driver.Manage().Window.Maximize();

        public static int TabCount(IWebDriver driver) => driver.WindowHandles.Count;

        public static void SwitchToFrame(IWebDriver driver, string iFrame) => driver.SwitchTo().Frame(FindElement(driver, iFrame));
        public static void SwitchToFrame(IWebDriver driver, IWebElement iFrame) => driver.SwitchTo().Frame(iFrame);
        public static void SwitchToDefaultFrame(IWebDriver driver) => driver.SwitchTo().DefaultContent();


        public static bool CheckUrl(IWebDriver driver, string url) => driver.Url.Contains(url);


        public static void SwitchToTab(IWebDriver driver, int to = 1) => driver.SwitchTo().Window(driver.WindowHandles[to]);

        public static Bitmap TakeAScreenshot(IWebDriver driver)
        {
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            return new Bitmap(new MemoryStream(screenshot.AsByteArray));

        }
        public static string UploadImage(IWebDriver driver)
        {
            try
            {
                if (!Directory.Exists($"{Directory.GetCurrentDirectory()}\\Screenshot\\"))
                    Directory.CreateDirectory($"{Directory.GetCurrentDirectory()}\\Screenshot\\");
                string imageName = $"{DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss")}.{ScreenshotImageFormat.Jpeg}";
                string filePath =
                    $"{Directory.GetCurrentDirectory()}\\Screenshot\\{imageName}";
                //bdtsdrttzvxmx@solarunited.net
                //Paroli1#
                Account account = new Account(
                 "dazhghkhv",
                   "793346215645576",
                   "Ka3fKVTYDmSIV2QaBpFSYweankQ");

                Cloudinary cloudinary = new(account);
                Bitmap imageFile = TakeAScreenshot(driver);
                imageFile.Save(filePath);
                ImageUploadParams uploadParams = new()
                {
                    File = new FileDescription(filePath)
                };
                var uploadResult = cloudinary.Upload(uploadParams);
                Uri uploadURL = uploadResult.Url;
                if (uploadURL == null)
                    return "Couldn't upload screenshot.";

                if (File.Exists(filePath))
                    File.Delete(filePath);

                return uploadResult.Url.ToString();
            }
            catch (Exception e)
            {
                return $"Couldn't upload screenshot {e.Message}";
            }
        }


        public static void SendMail(string Subject, string Attachment, string email)
        {
            MailMessage mail = new() 
            {
                From = new MailAddress("your mail@gmail.com"),
                Subject = Subject,
                Body = "For test results, check attachment"
            };
            SmtpClient SmtpServer = new("smtp.gmail.com") 
            {
                Port = 587,
                Credentials = new NetworkCredential("tavtmiani@gmail.com", "Ee8174568"),
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false

            };
            mail.To.Add(email);
            mail.Attachments.Add(new Attachment(Attachment));
            SmtpServer.Send(mail);

           
        }
    }
}

using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using Thinscale.Challenging.DOM.Tests;

namespace Thinscale.Challenging.DOM.Utils
{
    public class ElementFetch
    {
        
            public IWebElement getWebElement(String identifierType, String identifierValue, IWebDriver driver)
            {
                switch (identifierType)
                {
                    case "ID":
                    return driver.FindElement(By.Id(identifierValue));
                    case "CSS":
                        return driver.FindElement(By.CssSelector(identifierValue));
                    case "TAGNAME":
                        return driver.FindElement(By.TagName(identifierValue));
                    case "XPATH":
                        return driver.FindElement(By.XPath(identifierValue));
                    default:
                        return null;
                }

            }

            public List<IWebElement> getListWebElements(String identifierType, String identifierValue, IWebDriver driver)
            {
                switch (identifierType)
                {
                    case "ID":
                        return (List<IWebElement>)driver.FindElement(By.Id(identifierValue));
                    case "CSS":
                        return (List<IWebElement>)driver.FindElement(By.CssSelector(identifierValue));
                    case "TAGNAME":
                        return (List<IWebElement>)driver.FindElement(By.TagName(identifierValue));
                    case "XPATH":
                        return (List<IWebElement>)driver.FindElement(By.XPath(identifierValue));
                    default:
                        return null;
                }
            }
    }
}


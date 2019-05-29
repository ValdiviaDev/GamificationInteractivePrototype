using UnityEngine;
using System.Collections.Generic;

public class GamificationManager : MonoBehaviour
{
    public GameObject mapGo;
    public GameObject mainGo;
    public GameObject profileGo;
    public GameObject mealsGo;
    public GameObject sushiGo;
    public GameObject buyGo;
    public GameObject thanksGo;

    public enum PageEnum : int { mapPage = 1, mainPage, profilePage, mealsPage, sushiPage, buyPage, thanksPage };
    
    public class Page
    {
        public GameObject pageGo;
        public PageEnum pageEnum;
    }

    Stack<PageEnum> previousPages = new Stack<PageEnum>();

    private Page currentPage = new Page();

    void Start()
    {
        currentPage.pageGo = mainGo;
        currentPage.pageEnum = PageEnum.mainPage;
    }

    public void OnClick(int page)
    {
        currentPage.pageGo.SetActive(false);
        previousPages.Push(currentPage.pageEnum);
        PageEnum newPage = (PageEnum)page;
        currentPage.pageEnum = newPage;
        switch (newPage)
        {
            case PageEnum.mapPage:
                currentPage.pageGo = mapGo;
                break;

            case PageEnum.mainPage:
                currentPage.pageGo = mainGo;
                break;

            case PageEnum.profilePage:
                currentPage.pageGo = profileGo;
                break;

            case PageEnum.mealsPage:
                currentPage.pageGo = mealsGo;
                break;

            case PageEnum.sushiPage:
                currentPage.pageGo = sushiGo;
                break;

            case PageEnum.buyPage:
                currentPage.pageGo = buyGo;
                break;

            case PageEnum.thanksPage:
                currentPage.pageGo = thanksGo; ;
                break;
        }
        currentPage.pageGo.SetActive(true);
    }

    public void OnClickBack()
    {
        if (previousPages.Count > 0)
        {
            currentPage.pageGo.SetActive(false);
            PageEnum item = previousPages.Pop();
            currentPage.pageEnum = item;
            switch (item)
            {

                case PageEnum.mapPage:
                    currentPage.pageGo = mapGo;
                    break;

                case PageEnum.mainPage:
                    currentPage.pageGo = mainGo;
                    break;

                case PageEnum.profilePage:
                    currentPage.pageGo = profileGo;
                    break;

                case PageEnum.mealsPage:
                    currentPage.pageGo = mealsGo;
                    break;

                case PageEnum.sushiPage:
                    currentPage.pageGo = sushiGo;
                    break;

                case PageEnum.buyPage:
                    currentPage.pageGo = buyGo;
                    break;

                case PageEnum.thanksPage:
                    currentPage.pageGo = thanksGo;
                    break;
            }
            currentPage.pageGo.SetActive(true);
        }
    }

    void LogQueue()
    {
        Debug.Log("Stack:\n");
        foreach (PageEnum page in previousPages)
            Debug.Log(page.ToString());
        Debug.Log("\n");
    }
}
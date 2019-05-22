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

    List<PageEnum> previousPages = new List<PageEnum>();

    private Page currentPage = new Page();

    void Start()
    {
        currentPage.pageEnum = PageEnum.mapPage;
        currentPage.pageGo = mainGo;
    }
    
    public void OnClick(int page)
    {
        currentPage.pageGo.SetActive(false);

        PageEnum newPage = (PageEnum)page;
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
                currentPage.pageGo = thanksGo;
                break;
        }
        currentPage.pageGo.SetActive(true);
        previousPages.Add(newPage);
    }

    public void OnClickBack()
    {
        if (previousPages.Count > 0)
        {
            currentPage.pageGo.SetActive(false);
            var item = previousPages[previousPages.Count - 1];
            previousPages.RemoveAt(previousPages.Count - 1);

            switch (item)
            {
                case PageEnum.main:

                    break;
                case PageEnum.map:

                    break;
                case PageEnum.page1:

                    break;
                case PageEnum.profile:

                    break;
            }

            currentPage.pageGo.SetActive(true);
        }
    }
}
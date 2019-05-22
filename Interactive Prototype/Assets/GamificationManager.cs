using UnityEngine;
using System.Collections.Generic;

public class GamificationManager : MonoBehaviour
{
    public GameObject mainGo;

    public enum PageEnum : int { main = 1, map, page1, profile }
    
    public class Page
    {
        public GameObject pageGo;
        public PageEnum pageEnum;
    }

    List<PageEnum> previousPages = new List<PageEnum>();

    private Page currentPage = new Page();

    void Start()
    {
        currentPage.pageEnum = PageEnum.main;
        currentPage.pageGo = mainGo;
    }
    
    public void OnClick(int page)
    {
        PageEnum newPage = (PageEnum)page;
        switch (newPage)
        {
            case PageEnum.main:
                // currentPage.pageGo = gameobject Main
                break;
            case PageEnum.map:

                break;
            case PageEnum.page1:

                break;
            case PageEnum.profile:

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
            var newPage = previousPages.Count;
            previousPages.RemoveAt(previousPages.Count - 1);

            switch (newPage)
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

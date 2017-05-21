using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIActions : MonoBehaviour
{
    private Button settingsBtn;
    private Button moreInfoBtn;
    internal GameObject sideMenu;
    internal GameObject moreInfo;
    Button backPanelBtn;
    GameObject backPanel;
    CanvasGroup backPanelGroup;
    bool useMenuCloser = true;

    void Start()
    {
        /*
         * This sets a game object, button and onClick eventListener to 
         * openOrClose method which takes two parameters (gameobject and boolean)
         */

        //SideMenu Button 
        sideMenu = GameObject.Find("SideMenu");
        settingsBtn = GameObject.Find("SettingsBtn").GetComponent<Button>();
        settingsBtn.onClick.AddListener(() => openMenu(sideMenu, true));
        
        //MoreInfo Button
        moreInfo = GameObject.Find("MoreInfo");
        moreInfoBtn = GameObject.Find("MoreInfoBtn").GetComponent<Button>();
        //moreInfoBtn.onClick.AddListener(() => moreInfo.SetActive(true));
        moreInfoBtn.onClick.AddListener(() => moreInfo.SetActive(true));

        backPanel = GameObject.Find("BackPanel");
        backPanelBtn = backPanel.GetComponent<Button>();
        backPanelGroup = backPanel.GetComponent<CanvasGroup>();
        backPanelBtn.onClick.AddListener(() => closeAllMenus());
        menuCloser(false);
    }

    void openMenu(GameObject menu, bool open)
    {
        menu.SetActive(open);
        if (open)
        {
            Animation animation = menu.GetComponent<Animation>();

            if (animation != null)
            {
                animation.wrapMode = WrapMode.Once;
                animation.Play();
            }
        }
        
        if (useMenuCloser)
        {
            menuCloser(sideMenu.activeInHierarchy || moreInfo.activeInHierarchy);
        }

    }

    void menuCloser(bool activate)
    {
        backPanelGroup.interactable = backPanelGroup.blocksRaycasts = activate;

    }
    internal void closeAllMenus()
    {
        openMenu(sideMenu, false);
        //openMenu(moreInfo, false);
    }
    
}

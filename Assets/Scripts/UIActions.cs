/*
 * PARALLEL APPLICATION @2017
 * 
 * These scripts will handle all of the actions required and used by the User Interface.
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIActions : MonoBehaviour {

    public GameObject backPanel;
    private GameObject sideMenu;
    public GameObject moreInfo;
    public GameObject vrar;
    public GameObject screenshotRecord;
    public GameObject models;
    public GameObject recordings;
    public GameObject settings;
    public GameObject help;
    public CanvasGroup backPanelGroup;
    private Button backPanelBtn;
    private Button sideMenuBtn;
    private Button moreInfoBtn;
    private Button vrarBtn;
    private Button screenshotRecordBtn;
    private Button modelsBtn;
    private Button recordingsBtn;
    private Button settingsBtn;
    private Button helpBtn;
    private Button sideMenuClose;
    private Button vrClose;
    private Button recordClose;
    private Button moreinfoClose;
    private Button modelsClose;
    private Button recordingsClose;
    private Button settingsClose;
    private Button helpClose;

    private enum PanelsToActivate{
        SideMenu, 
        VRPanel,
        RecordPanel,
        ModelsPanel,
        RecordingsPanel,
        SettingsPanel,
        HelpPanel
    }

    private bool openMenu(GameObject panel, PanelsToActivate panels, bool isClosed) {

        switch (panels){
            case PanelsToActivate.SideMenu:
                sideMenu = GameObject.Find("SideMenu");
                Vector3 endpos = Vector3(;

                Vector3 startpos = sideMenu.GetComponent<RectTransform>().position;
                Vector3 endpos = new Vector3(320, sideMenu.GetComponent<RectTransform>().position.y, sideMenu.GetComponent<RectTransform>().position.z);
                float speed = 1.0f;

                transform.position = 
                break;
        }

        return isClosed;
    }

    void slideUp() { }
     
    void Start() {
        /*
         * This sets a game object, button and onClick eventListener to 
         * openOrClose method which takes two parameters (gameobject and boolean)
         */
        
        // find open buttons
        backPanel = GameObject.Find("BackPanel");
        backPanelBtn = backPanel.GetComponent<Button>();
        sideMenuBtn = GameObject.Find("MenuBtn").GetComponent<Button>();
        moreInfoBtn = GameObject.Find("MoreInfoBtn").GetComponent<Button>();
        vrarBtn = GameObject.Find("VRBtn").GetComponent<Button>();
        screenshotRecordBtn = GameObject.Find("RecordBtn").GetComponent<Button>();
        modelsBtn = GameObject.Find("MyModelsBtn").GetComponent<Button>();
        recordingsBtn = GameObject.Find("MyRecordingsBtn").GetComponent<Button>();
        settingsBtn = GameObject.Find("SettingsBtn").GetComponent<Button>();
        helpBtn = GameObject.Find("HelpBtn").GetComponent<Button>();

        // find close buttons
        sideMenuClose = GameObject.Find("sideMenuCloseBtn").GetComponent<Button>();
        vrClose = GameObject.Find("vrCloseBtn").GetComponent<Button>();
        recordClose = GameObject.Find("recordCloseBtn").GetComponent<Button>();
        moreinfoClose = GameObject.Find("moreinfoCloseBtn").GetComponent<Button>();
        modelsClose = GameObject.Find("modelsCloseBtn").GetComponent<Button>();
        recordingsClose = GameObject.Find("recordingsCloseBtn").GetComponent<Button>();
        settingsClose = GameObject.Find("settingsCloseBtn").GetComponent<Button>();
        helpClose = GameObject.Find("helpCloseBtn").GetComponent<Button>();

        // find panels
        
        moreInfo = GameObject.Find("MoreInfo");
        vrar = GameObject.Find("VRAR");
        screenshotRecord = GameObject.Find("Record");
        models = GameObject.Find("Models");
        recordings = GameObject.Find("Recordings");
        settings = GameObject.Find("Settings");
        help = GameObject.Find("Help");

        backPanelGroup = backPanel.GetComponent<CanvasGroup>();

        sideMenuBtn.onClick.AddListener(() => playAnimation(sideMenu, panelstoactivate));
        vrarBtn.onClick.AddListener(() => playAnimation(vrar, panelstoactivate));
        screenshotRecordBtn.onClick.AddListener(() => playAnimation(screenshotRecord, panelstoactivate));
        modelsBtn.onClick.AddListener(() => playAnimation(screenshotRecord, panelstoactivate));
        recordingsBtn.onClick.AddListener(() => playAnimation(recordings, panelstoactivate));
        settingsBtn.onClick.AddListener(() => playAnimation(settings, panelstoactivate));
        helpBtn.onClick.AddListener(() => playAnimation(help, panelstoactivate));

        sideMenuClose.onClick.AddListener(() => closeMenu(sideMenu, panelstoactivate));

        moreInfoBtn.onClick.AddListener(() => moreInfo.SetActive(true));
    }
}

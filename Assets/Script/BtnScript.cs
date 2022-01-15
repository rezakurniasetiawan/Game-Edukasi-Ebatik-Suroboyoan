using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BtnScript : MonoBehaviour
{

    public void btnMasuk()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void btnTentangApp()
    {
        SceneManager.LoadScene("TentangApp");
    }
    public void btnMenuMateri()
    {
        SceneManager.LoadScene("MenuMateri");
    }
    public void btnGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void Kompetisidasar()
    {
        SceneManager.LoadScene("KompetisiDasar");
    }
    public void gamelevel1()
    {
        SceneManager.LoadScene("Game1");
    }
    public void gamelevel2()
    {
        SceneManager.LoadScene("Game2");
    }
    public void gamelevel3()
    {
        SceneManager.LoadScene("Game3");
    }
    public void gamelevel4()
    {
        SceneManager.LoadScene("Game4");
    }
    public void backMainmenukeawal()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void backTentangappkeawal()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void backMenumaterikeMainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void backgamekeMainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void backBatik()
    {
        SceneManager.LoadScene("MenuMateri");
    }
    public void mainlagigame1()
    {
        SceneManager.LoadScene("Game1");
    }
    public void mainlagigame2()
    {
        SceneManager.LoadScene("Game2");
    }
    public void level1lannjut()
    {
        SceneManager.LoadScene("Game2");
    }
    public void level2lannjut()
    {
        SceneManager.LoadScene("Game2");
    }
    public void openlevel()
    {
        SceneManager.LoadScene("Gameopen2");
    }
    public void openlevel3()
    {
        SceneManager.LoadScene("Gameopen3");
    }
    public void openlevel4()
    {
        SceneManager.LoadScene("Gameopen4");
    }
}

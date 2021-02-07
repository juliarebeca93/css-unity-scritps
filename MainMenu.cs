using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//biblioteca SceneManagement é obrigatória para gerenciamento das cenas do projeto

public class MainMenu : MonoBehaviour
{
    //comando ao botão que direcionará para a cena que contémm o gameplay

    //entre parenteses é referenciado o nome da cena
    public void GoToPlay()
    {
        SceneManager.LoadScene("Gameplay");
    }

    //comando ao botão que direcionará para a cena que contém o menu principal
    public void GoToBackMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    //comando ao botão que encerrará a aplicação na plataforma windows
    public void QuitGame()
    {
	//log acrescentado para confirmação da ação através do console do Unity
        Debug.Log("Fechando o jogo");
        Application.Quit();
    }
    

}

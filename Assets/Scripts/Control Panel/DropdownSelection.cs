using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class DropdownSelection : MonoBehaviour
{
    [SerializeField] private PhotonView _photonView;
    [SerializeField] private TMP_Text _header;
    [SerializeField] private TMP_Text _label;
    [SerializeField] private TMP_Text _resetObjects;
    [SerializeField] private TMP_Text _resetBoards;
    [SerializeField] private TMP_Text _whiteBoard;
    [SerializeField] private TMP_Text _blackBoardOne;
    [SerializeField] private TMP_Text _blackBoardTwo;
    [SerializeField] private TMP_Text _blackBoardThree;
    
    public void DropdownLanguage(int index)
    {
        int selectedCase = index;

        _photonView.RPC("SyncDropdownLanguage", RpcTarget.AllBuffered, selectedCase);
    }

    [PunRPC]
    void SyncDropdownLanguage(int index)
    {
        switch (index)
        {
            case 0: // Engelsk
            _header.text = "Control Panel";
            _label.text = "English";
            _resetObjects.text = "Reset Objects";
            _resetBoards.text = "Reset Boards";
            _whiteBoard.text = "Whiteboard";
            _blackBoardOne.text = "Blackboard 1";
            _blackBoardTwo.text = "Blackboard 2";
            _blackBoardThree.text = "Blackboard 3";
            break;
            case 1: // Dansk
            _header.text = "Kontrolpanel";
            _label.text = "Dansk";
            _resetObjects.text = "Nulstil objekter";
            _resetBoards.text = "Nulstil Tavler";
            _whiteBoard.text = "White Board";
            _blackBoardOne.text = "Tavle 1";
            _blackBoardTwo.text = "Tavle 2";
            _blackBoardThree.text = "Tavle 3";
            break;
            case 2: // Finsk
            _header.text = "Hallintapaneeli";
            _label.text = "Suomalainen";
            _resetObjects.text = "Nollaa kohteet";
            _resetBoards.text = "Nollaa taulut";
            _whiteBoard.text = "Valkotaulu";
            _blackBoardOne.text = "Liitutaulu 1";
            _blackBoardTwo.text = "Liitutaulu 2";
            _blackBoardThree.text = "Liitutaulu 3";            
            break;
            case 3: // Spansk
            _header.text = "Panel de control";
            _label.text = "Español";
            _resetObjects.text = "Restablecer objetos";
            _resetBoards.text = "Restablecer pizzaras";
            _whiteBoard.text = "Pizarra blanca";
            _blackBoardOne.text = "Pizarra negra 1";
            _blackBoardTwo.text = "Pizarra negra 2";
            _blackBoardThree.text = "Pizarra negra 3";
            break;
            case 4: // Kroatisk
            _header.text = "Upravljačka ploča";
            _label.text = "Hrvatski";
            _resetObjects.text = "Resetiraj objekte";
            _resetBoards.text = "Resetiraj ploče";
            _whiteBoard.text = "Bijela ploča";
            _blackBoardOne.text = "Školska ploča 1";
            _blackBoardTwo.text = "Školska ploča 2";
            _blackBoardThree.text = "Školska ploča 3";
            break;
            case 5: // Græsk
            _header.text = "Πίνακας Eλέγχου";
            _label.text = "Ελληνικά";
            _resetObjects.text = "Επαναφορά Αντικειμένων";
            _resetBoards.text = "Επαναφορά Πινάκων";
            _whiteBoard.text = "Λευκός Πίνακας";
            _blackBoardOne.text = "Μαύρος Πίνακας 1";
            _blackBoardTwo.text = "Μαύρος Πίνακας 2";
            _blackBoardThree.text = "Μαύρος Πίνακας 3";
            break;
            default:
            break;
        }
    }
}

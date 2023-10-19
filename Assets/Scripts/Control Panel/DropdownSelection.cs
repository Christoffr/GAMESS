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
            case 0: // English
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
            case 2: // Suomalainen
            _header.text = "Ohjauspaneeli";
            _label.text = "Suomalainen";
            _resetObjects.text = "Palauta objektit";
            _resetBoards.text = "Nollaa levyt";
            _whiteBoard.text = "Valkotaulu";
            _blackBoardOne.text = "Liitutaulu 1";
            _blackBoardTwo.text = "Liitutaulu 2";
            _blackBoardThree.text = "Liitutaulu 3";            
            break;
            case 3: // Español
            _header.text = "Panel de control";
            _label.text = "Español";
            _resetObjects.text = "Restablecer objetos";
            _resetBoards.text = "Restablecer tableros";
            _whiteBoard.text = "Pizarron";
            _blackBoardOne.text = "Pizarra 1";
            _blackBoardTwo.text = "Pizarra 2";
            _blackBoardThree.text = "Pizarra 3";
            break;
            case 4: // Hrvatski
            _header.text = "Upravljačka ploča";
            _label.text = "Hrvatski";
            _resetObjects.text = "Resetiraj objekte";
            _resetBoards.text = "Resetiraj ploče";
            _whiteBoard.text = "Bijela ploča";
            _blackBoardOne.text = "Ploča 1";
            _blackBoardTwo.text = "Ploča 2";
            _blackBoardThree.text = "Ploča 3";
            break;
            case 5: // Ελληνικά
            _header.text = "Πινακας Ελέγχου";
            _label.text = "Ελληνικά";
            _resetObjects.text = "Επαναφορά αντικειμένων";
            _resetBoards.text = "Επαναφορά πλακών";
            _whiteBoard.text = "Λευκός πίνακας";
            _blackBoardOne.text = "Μαυροπίνακας 1";
            _blackBoardTwo.text = "Μαυροπίνακας 2";
            _blackBoardThree.text = "Μαυροπίνακας 3";
            break;
            case 6: // Türkçe
            _header.text = "Kontrol Paneli";
            _label.text = "Türkçe";
            _resetObjects.text = "Nesneleri sıfırla";
            _resetBoards.text = "Panoları sıfırla";
            _whiteBoard.text = "Beyaz tahta";
            _blackBoardOne.text = "Karatahta 1";
            _blackBoardTwo.text = "Karatahta 2";
            _blackBoardThree.text = "Karatahta 3";
            break;
            default:
            break;
        }
    }
}

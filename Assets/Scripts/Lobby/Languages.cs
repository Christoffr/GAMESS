using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Languages : MonoBehaviour
{
    [SerializeField] private TMP_Text _findRoom;
    [SerializeField] private TMP_Text _createRoom;
    [SerializeField] private TMP_Text _selectAvatar;
    [SerializeField] private TMP_Text _quit;
    [SerializeField] private Text _createPlaceholder;
    [SerializeField] private TMP_Text _createCreateButton;
    [SerializeField] private TMP_Text _createBack;
    [SerializeField] private TMP_Text _find;
    [SerializeField] private TMP_Text _findBack;
    [SerializeField] private TMP_Text _avatarBack;
    
    public void changesLanguages(int index)
    {
        switch(index)
        {
            case 0: // English
                _findRoom.text = "Find Room";
                _createRoom.text = "Create Room";
                _selectAvatar.text = "Select Avatar";
                _quit.text = "Quit";

                _createPlaceholder.text = "Enter Room Name";
                _createCreateButton.text = "Create Room";
                _createBack.text = "Back";

                _find.text = "Find Room";
                _findBack.text = "Back";

                _avatarBack.text = "Back";
            break;
            case 1: // Dansk
                _findRoom.text = "Find Rum";
                _createRoom.text = "Lav Rum";
                _selectAvatar.text = "Vælg Avatar";
                _quit.text = "Afslut";

                _createPlaceholder.text = "Skriv Rum Navn";
                _createCreateButton.text = "Lav Rum";
                _createBack.text = "Tilbage";

                _find.text = "Find Rum";
                _findBack.text = "Tilbage";

                _avatarBack.text = "Tilbage";
            break;
            case 2: // Suomalainen        
                _findRoom.text = "Etsi Huone";
                _createRoom.text = "Luo Huone";
                _selectAvatar.text = "Valitse Avatar";
                _quit.text = "Lopettaa";

                _createPlaceholder.text = "Anna Huoneen Nimi";
                _createCreateButton.text = "Luo Huone";
                _createBack.text = "Takaisin";

                _find.text = "Etsi Huone";
                _findBack.text = "Takaisin";

                _avatarBack.text = "Takaisin";            
            break;
            case 3: // Español
                _findRoom.text = "Encontrar Habitación";
                _createRoom.text = "Crear Habitación";
                _selectAvatar.text = "Seleccionar Avatar";
                _quit.text = "Abandonar";

                _createPlaceholder.text = "Ingrese el Nsombre de la Habitación";
                _createCreateButton.text = "Crear Habitación";
                _createBack.text = "Atrás";

                _find.text = "Encontrar Habitación";
                _findBack.text = "Atrás";

                _avatarBack.text = "Atrás";            
            break;
            case 4: // Hrvatski
                _findRoom.text = "Pronađite Sobu";
                _createRoom.text = "Stvori Sobu";
                _selectAvatar.text = "Odaberite Avatar";
                _quit.text = "Prestati";

                _createPlaceholder.text = "Unesite Naziv Sobe";
                _createCreateButton.text = "Stvori Sobu";
                _createBack.text = "Leđa";

                _find.text = "Pronađite Sobu";
                _findBack.text = "Leđa";

                _avatarBack.text = "Leđa";
            break;
            case 5: // Ελληνικά
                _findRoom.text = "Εύρεση δωματίου";
                _createRoom.text = "Δημιουργία δωματίου";
                _selectAvatar.text = "Επιλέξτε Avatar";
                _quit.text = "Εγκαταλείπω";

                _createPlaceholder.text = "Εισαγάγετε το όνομα δωματίου";
                _createCreateButton.text = "Δημιουργία δωματίου";
                _createBack.text = "Πίσω";

                _find.text = "Εύρεση δωματίου";
                _findBack.text = "Πίσω";

                _avatarBack.text = "Πίσω";
            break;
            default:
            break;
        }
    }  
}

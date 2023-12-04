
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class SkyboxButton : UdonSharpBehaviour {
    public int Select;
    public SkyboxController _Controller;
       

    public void Interact() {
            
        if (_Controller != null) {
            _Controller.UpdateSelected(Select);

        }
    }
}

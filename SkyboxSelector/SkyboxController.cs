
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class SkyboxController : UdonSharpBehaviour
{

    [UdonSynced] private int Selected;
    private int Previous;
    public GameObject[] Skyboxes = new GameObject[12];

    private void Start() {
        this.Selected = 0;
        this.Previous = 0;
        Debug.Log("Start:" + this.Selected + " " + this.Previous);

        if (Skyboxes[this.Selected] && Skyboxes[this.Selected].activeSelf) {
                Skyboxes[this.Selected].SetActive(true);
            }

            for (int i = 1; i < Skyboxes.Length; i++) {
                if (Skyboxes[i] && Skyboxes[i].activeSelf) {
                    Skyboxes[i].SetActive(false);
                }
            }
         
    }

    private void Update() {
        Debug.Log("Before Update:" + this.Selected + " " + this.Previous);
        if (this.Selected == this.Previous) {
            return;
        }
        if (this.Selected >= Skyboxes.Length) {
            this.Selected = 0;
        }


        if (Skyboxes[this.Previous]) {
            Skyboxes[this.Previous].SetActive(false);
        }
        if (Skyboxes[this.Selected]) {
            Skyboxes[this.Selected].SetActive(true);
        }

        this.Previous = this.Selected;
        Debug.Log("After Update:" + this.Selected + " " + this.Previous);

    }
    public void UpdateSelected(int x) {
        this.Selected = x;
    }


}

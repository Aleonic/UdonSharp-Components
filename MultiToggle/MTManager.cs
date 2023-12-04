using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class MultiToggleManager : UdonSharpBehaviour {

    // Collection of Objects that will be set Active or Inactive based on selected value.
    public GameObject[] triggeredObjects = new GameObject[10];

    // Controller values
    private int selected = 0;
    private int previous = 0;


    void Start() {
        // init
        this.selected = 0;
        this.previous = 0;
        Debug.Log("On start:" + this.selected + " " + this.previous);

        if (triggeredObjects[this.selected] && !triggeredObjects[this.selected].activeSelf) {
                triggeredObjects[this.selected].SetActive(true);
        }

        for (int i = 1; i < triggeredObjects.Length; i++) {
            if (triggeredObjects[i] && triggeredObjects[i].activeSelf) {
                triggeredObjects[i].SetActive(false);
            }
        }
    }

    private void Update() {
        if (this.selected == this.previous) {
            return;
        }

        if (this.selected >= triggeredObjects.Length) {
            this.selected = 0;
        }

        if (triggeredObjects[this.Previous]) {
            triggeredObjects[this.Previous].SetActive(false);
        }

        if (triggeredObjects[this.selected]) {
            triggeredObjects[this.selected].SetActive(true);
        }

        this.Previous = this.selected;
    }

    public void UpdateSelected(int x) {
        this.Selected = x;
    }
}
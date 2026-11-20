# MG7
## Devlog
In my tree of birds script, this is what allows the birds to pop out the tree. I added [SerializeField] GameObject[] birds as an array for all the birds in the tree. All the birds follow the code. The foreach loop allows for every bird the same rules such as checking the player distance. When you step closer to the tree, _interactionDistance lets the birds pop up since it is SetActive(true). Vector3 is used here to check where the bird and player are from a distance. 

https://pearl-carp.itch.io/mg7



## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models

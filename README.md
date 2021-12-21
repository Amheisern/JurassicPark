# JurassicPark

PEDAC
problem

    Create a simple console application that manages the dinosaurs in your zoo.

-need a way to manage a dino data of a dino zoo
-need to be able to list dinos by properties
-- name, diet type, date acquired, weight, enclosure number
-Each Dino should have a description or a print of the listed properties for each dino
-That database should have a menu to manage the database  
 --View by name
--View by enclosure number
--Add dino with a function for auto time and date
--Remove a dino from the database
--Transfer (update) dino name or enclosure number
--View number of carnivores and the number of herbivores.
--ability to quit

- examples
  Ankylosaurus
  Brachiosaurus
  Coelophysis
  Iguanodon
  Stegoceras
  Stegosaurus
  Triceratops
  Tyrannosaurus
  Velociraptor

  data
  class for dinos
  class for dino data base
  -- method to quit Q
  -- method for Remove R
  -- method for Add A
  -- method for find F
  -- method for transfer T (update)
  -- method to display # of herb and carnivores
  -- method to show all properties of a dino object
  method
  -display greeting
  -prompt for string
  -prompt for integer
  menu
  -Q, D, R, A, F, T, S

  algorithm
  display greeting "Welcome to JurassicPark D.R.A.F.T.S database"
  display menu "please make a selection"
  If choice is "Q"
  --While statement encapsulation
  --if Q this var keepGoing while statement false and break while loop encapsulation
  If choice is "D"
  --Display total count of diet type herbivores and the count of diet type carnivores
  code
  If choice is "R"
  -- ask user "which dino are you looking for?"
  --- If dino not found display " No such Dino "
  --- If dino is found display dino name and location
  --- Ask use to confirm correct dino name
  ---- If yes .remove dino
  ---- If not return to menu?
  If choice is "A"
  -- var new dinos
  -- prompt for all properties one and a time
  -- add to database
  If choice is "F"
  -- ask user "which dino are you looking for?"
  --- If dino not found display " No such Dino "
  --- If dino is found display dino name and location
  If choice is "T"
  -- ask user "which dino are you looking for?"
  --- If dino not found display " No such Dino "
  --- If dino is found display dino name and location
  --- Ask user which property they would changes

  If choice is "S"
  -- ask user "which dino are you looking for?"
  --- If dino not found display " No such Dino "
  --- If dino is found display all properties

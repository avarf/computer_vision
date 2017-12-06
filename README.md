# Computer Vision Repository


This repository contains different projects for learning how to use OpenCV, Emgu CV, C# and Visual Studio and also implementation of two projects, pedestrian detection and pedestrian detection using thermal camera.

These two projects will use HOG (Histogram of Oriented Gradient) and SVM to detect pedestrians.

## Working With Emgu CV
In Visual Studio after creating our new project we should follow these steps:

* Right click on the project name in the Solution toolbox and Add -> References -> add all the Emgu dll files
* Add the opencv files to the project: Add -> Existing item -> Emgu-bin-X64
* Select all the added opencv files and right click  -> Properties -> change "Copy to Output" to always
* Right click on the project name in the Solution toolbox and Properties -> build -> change CPU to X64
# Tutorial

1. Create wpf project

  ![1.PNG](images/1.PNG)

2. Manage nuget packages

  ![2.PNG](images/2.PNG)

3. Search Caliburn Micro and install

  ![3.PNG](images/3.PNG)

4. Wait for Finished

  ![4.PNG](images/4.PNG)

5. Create first viewmodel. Right now we just have a count that takes 1000 milliseconds to increment (but not lock the ui for that time). Notice the NotifyPropertyChanged that let's the ui know when to refresh.

  ![5.PNG](images/5.PNG)

6. (one time setup) Create a bootstrapper so Caliburn Micro can take over.

  ![6.PNG](images/6.PNG)

7. (one time setup) Put that bootstrapper in the root application resources so it can take over.

  ![7.PNG](images/7.PNG)

8. Create a UI that will independently load properties and methods from the ViewModel

  ![8.PNG](images/8.PNG)

9. Run the project and notice you can click the button infinitely without locking the ui, even while waiting for the previous click.

  ![9.PNG](images/9.PNG)

# DependencyInjection

Dependency Injection means isolating dependencies.

That is, it is an approach that says that you should not create the "new" keyword if you are going to use the object of 
another class in a class that you will basically create. It emphasizes that the required object must be retrieved as parameter 
by either the Constructor or the Setter method. Thus, it argues that we have isolated the two classes from each other.

To summarize, the structures that make up the software are inevitably dependent. However, it is important to keep the 
relationship as loose as possible so that this dependency does not cause a bond or limitation.  We call it Loosely Coupled.  
Therefore, it is easy to add new features to the application (Open-Closed Principle (OCP) of SOLID), as the structures that 
make up the software are less tightly connected to each other. 

Dependency Injection is often confused with Dependency Inversion. But Dependency Inversion is a principle for problem solving, 
while Dependency Injection is a Design Pattern that applies this principle.

(D) - Dependency Inversion in SOLID: In layered architectures, the top-level modules must not be directly dependent on the 
bottom-level modules.

“Let the car class change as much as it wants, but the Vasita class doesn't need to know about it. It doesn't need that 
I won't have to deal with the Vasita class, if we will apply the Dependency Injection (DI) design.

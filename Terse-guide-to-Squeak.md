# Terse guide to Squeak

**Original: http://wiki.squeak.org/squeak/5699**

## Allowable characters

**Allowable characters:**
 - a-z                                                             
 - A-Z                                                             
 - 0-9                                                             
 - .+/\~<>@%|&?                                                   
 - blank, tab, cr, ff, lf                                          
																   
**Variables:**
 - variables must be declared before use                           
 - shared vars must begin with uppercase                           
 - local vars must begin with lowercase                            
 - reserved names: nil, true, false, self, super, and Smalltalk    
																   
**Variable scope:**
 - Global: defined in Dictionary Smalltalk and accessible by all   
	  objects in system                                            
 - Special: (reserved) Smalltalk, super, self, true, false, & nil  
 - Method Temporary: local to a method                             
 - Block Temporary: local to a block                               
 - Pool: variables in a Dictionary object                          
 - Method Parameters: automatic local vars created as a result of  
	  message call with params                                     
 - Block Parameters: automatic local vars created as a result of   
	  value: message call                                          
 - Class: shared with all instances of one class & its subclasses  
 - Class Instance: unique to each instance of a class              
 - Instance Variables: unique to each instance                     

```smalltalk
"Comments are enclosed in quotes"
"Period (.) is the statement seperator"
```

## Transcript
```smalltalk
Transcript clear.                                           "clear to transcript window"
Transcript show: 'Hello World'.                             "output string in transcript window"
Transcript nextPutAll: 'Hello World'.                       "output string in transcript window"
Transcript nextPut: $A.                                     "output character in transcript window"
Transcript space.                                           "output space character in transcript window"
Transcript tab.                                             "output tab character in transcript window"
Transcript cr.                                              "carriage return / linefeed"
'Hello' printOn: Transcript.                                "append print string into the window"
'Hello' storeOn: Transcript.                                "append store string into the window"
Transcript endEntry.                                        "flush the output buffer"
```

## Assignment
```smalltalk
| x y |
x _ 4.                                                      "assignment (Squeak) <-"
x := 5.                                                     "assignment"
x := y := z := 6.                                           "compound assignment"
x := (y := 6) + 1.
x := Object new.                                            "bind to allocated instance of a class"
x := 123 class.                                             "discover the object class"
x := Integer superclass.                                    "discover the superclass of a class"
x := Object allInstances.                                   "get an array of all instances of a class"
x := Integer allSuperclasses.                               "get all superclasses of a class"
x := 1.2 hash.                                              "hash value for object"
y := x copy.                                                "copy object"
y := x shallowCopy.                                         "copy object (not overridden)"
y := x deepCopy.                                            "copy object and instance vars"
y := x veryDeepCopy.                                        "complete tree copy using a dictionary"
```


 ## Constants:
 ```smalltalk
| b |
b := true.                                                  "true constant"
b := false.                                                 "false constant"
x := nil.                                                   "nil object constant"
x := 1.                                                     "integer constants"
x := 3.14.                                                  "float constants"
x := 2e-2.                                                  "fractional constants"
x := 16r0F.                                                 "hex constant".
x := -1.                                                    "negative constants"
x := 'Hello'.                                               "string constant"
x := 'I''m here'.                                           "single quote escape"
x := $A.                                                    "character constant"
x := $ .                                                    "character constant (space)"
x := #aSymbol.                                              "symbol constants"
x := #(3 2 1).                                              "array constants"
x := #('abc' 2 $a).                                         "mixing of types allowed"
```

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

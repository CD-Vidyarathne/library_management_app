# **GUI application development coursework submission.**

## Group members:

1. Chamindu Vidyarathne *KADSE222F-048*
2. Anjalika De Silva *KADSE222F-046*
3. Thisaru Pathirana *KADSE222F-050*
4. Sanjana Rathnayake *KADSE222F-037*

## Description

This is a basic library management app which completes the basic needs of a library.

## Project Scope
The functions of the library can be categorized as below:
*Loan Process, Return Process, Reservation process, Inquiry Process, Book Registration Process
and User Registration process.*
Details about these functions are given below:

**01. Loan Process:**
A particular book can have many copies available in the library. A Copy is a physical book while a Title
is the class of all books which are identical, i.e. "Access 2022 all-in-one desk reference for dummies, by
Alan Simpson, Margaret Levine Young and Alison Barrows, ISBN: 978-0-470-03649-5" is a Title while
the physical book on the bookshelf is a Copy.
The borrower collects the copies of books that is required and hand over them to the library counter. The
Librarian will check whether the borrower has an overdue of books to be returned because a borrower
can borrow only maximum of 5 books from the library at a time. If the borrower exceeded the maximum
count then they cannot borrow until the overdue books are returned.
Then the Librarian will check the status of each copy which indicates whether the copy is "Reference"
only where referenced copies are not "borrowable". If the book is "Borrowable" then the loan will be
confirmed and the expected return date will be informed to the borrower. The Librarian has the authority
to accept or cancel the request for a loan and a copy of a book can be borrowed for a period of two weeks.

**02. Return Process:**
The Librarian accepts the return and checks the status of the copy. If the copy is already reserved, the
librarian takes steps to inform the member who has reserved the copy.

**03.Reservation Process:**
On return, the reservations are checked to see if there is an outstanding reservation for the title a copy of
which is being returned. If so, a message is displayed and the librarian puts the book (copy) on one side,
a notification is generated for the borrower with the oldest reservation for the title and the oldest
reservation for the title is deleted.

**04.Inquiry Process:**
The Librarian can also handle inquiries from the borrower about the availability of a book.

**05. Book Registration Process:**
The Librarian enters the details of new books and its copies. A maximum of 10 copies are allowed to be
registered per book number. The Librarian records the classification, book title, publisher, whether the
copy is reference or borrowable.
The book number comprises
-Classification *(1 byte classification)*
- X 99994 *byte integer staring from 0001*
The copy number in case of multiple copies has the same structure with an extra number appended at
the end.

**06.User Registration Process:**
New borrowers may also be registered. The following is captured for the user registration.

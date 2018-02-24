
insert into Contacts (Name, Email,Address1, Address2, City, State, PostalCode, Phone, IsPhoneMobile)
values('Mark Baird', 'mark@baird.org', '628 Goodview Ave N.', null, 'Oakdale', 'MN', '55128', 6514429504, 1)

insert into Contacts (Name, Email,Address1, Address2, City, State, PostalCode, Phone, IsPhoneMobile)
values('Janis Baird', 'janis@baird.org','628 Goodview Ave N.', 'Apt. B', 'Oakdale', 'MN', '55128', null, null)

insert into Contacts (Name, Email,Address1, Address2, City, State, PostalCode, Phone, IsPhoneMobile)
values('Jeremy Baird', 'jeremy@baird.org','628 Goodview Ave N.', null, 'Oakdale', 'MN', '55128', null,null)

insert into Contacts (Name, Email, Address1, City, State, PostalCode, Phone, IsPhoneMobile) 
values ('Bob Hope', 'bobhope@mail.com', 'someaddress', 'somecity', 'CA', '55236', '6514429504',1)


insert into SectionContent (ContactId, Title, Content, SortOrder)
values (1, 'Profession Summary','<ul><li>An experienced Senior Software Engineer with extensive experience in Object Oriented Analysis and Design and design patterns.</li><li>An experienced full stack Software Engineer passionate about agile software development with expertise in design, development and construction of software applications built on Microsoft .NET platform.</li><li>Strong oral and written communications skills, including development of formal software engineering principles, practices and processes.</li><li>Self-directed with proven analytical skills called upon to resolve complex problems and implement solutions.</li><li>Selected to advanced team within Merrill Corporation to evaluate new business potential.</li><li>Technical specialist and evangelist in agile software development, test driven development, continuous integration and object oriented designs. </li><li>Introduced and evangelized industry standard software engineering principles, practices and processes.</li><li>Balanced the trade-offs between technical, analytical, and product needs that resulted in effective solutions.</li><li>Subject matter expert in the business domain of document management and composition, regulatory compliance, financial reporting and XBRL.</li><li>Initiated and contributed to the Software Engineering Community of Practice.</li></ul>	',1)

insert into SectionContent (ContactId, Title, Content, SortOrder)
values (1, 'Technical Skills','<p>Knockout, Bootstrap, ReST, AngularJS, JavaScript, MVC, C#, HTML, Xlink, XML, XSLT, SQL, VSTO, GIT CSS2/CSS3</p>',2)

insert into SectionContent (ContactId, Title, Content, SortOrder)
values (1, 'C.H.Robinson','<p><i>Software Engineer II (November 2016 to August 2017)</i></p><ul><li><b>Partnered with team to build a prototype Skype bot.</b> Using the Skype SDK and Microsoft’s <a href="https://www.luis.ai/home" target="_blank"> Language Understanding Intelligent Service</a> (LUIS) sales was able to use Skype to ask questions about the status of their customers’ orders.</li><li><b>Mentored and lead team with the performance tuning of a WPF application running on Citrix servers.</b> Setup each team members with the proper performance profiling tool sets in addition to the needed resources to assist the team with .NET GC and memory management. Established and setup test data and a test plan on all environments so that progress could be consistently measured with known inputs. Introduced the team to “feature branching” to isolate performance changes and testing.</li></ul>	',3)

insert into SectionContent (ContactId, Title, Content, SortOrder)
values (1, 'Merrill Communications','<p><i>Senior Software Engineer (2005 to August 2016)</i></p><ul><li><b>Reduced maintenance costs and response times to Security and Exchange Commission’s (SEC) evolving compliance requirements.</b> Partnered with Senior Engineer to design, prototype and build a SaaS “wizard framework” using C#, MVC, Bootstrap, Knockout achieving 95% unit test coverage. This framework provided the business with the ability to provide customers an easy way to navigate the complex workflow of SEC form submission and to quickly respond to SEC compliance changes without additional development.</li><li><b>Selected to be a member of an advanced team, on-site in Denver, to evaluate, document SaaS solution and establish a working relationship with business partner.</b> Used UML sequence, state and class diagrams to understand and document the system. This allowed us to determine the level of effort needed for new functional enhancements. This also allowed new team members to quickly identify and the learn the functional areas that needed to be enhanced.</li><li><b>Technical Lead responsible for the maintenance of Merrill’s SaaS application.</b> I was the domain and application expert tasked with leading a team across time zones to enhance and maintain Merrill’s financial transaction and regulatory disclosure platform.</li><li><b>Partnered with Senior Software Engineer to develop and publish software engineering principles, practices and processes.</b> These engineering principles, practices and processes were technology agnostic and provided each team within Merrill the flexibility to use the appropriate technologies needed for their domain to build loosely coupled, highly cohesive, testable applications.</li><li><b>Successfully led a team of five increasing the performance of an XBRL reporting engine by 50%.</b> Provided support to the team to help them understand the domain and determine the best design patterns to use. This provided the opportunity for the business to increase their market share of large cap companies with large data sets and complex data relationships.</li><li><b>Increased team’s sprint velocity by mentoring junior developers</b> in Agile methodologies and practices in Test Driven Development, code refactoring, design, estimation, and planning.  </li><li><b>Successfully removed performance bottleneck of desktop application.</b> Redesigned reporting engine to generate three reports asynchronously using multiple threads and CPU cores.</li></ul><p><i>Lead Developer (2001 – 2005)</i></p><ul><li><b>Designed and built solution that reduced labor cost associated with scaling during quarterly SEC filing peaks.</b> Successfully designed and built C2 platform on Microsoft Word to facilitate the conversion of financial compliance documents into HTML. This allowed Merrill to eliminate the training involved for the creation of HTML documents, allowing Merrill to scale each quarter with temporary workers that were skilled in using Word.</li></ul>',4)

insert into SectionContent (ContactId, Title, Content, SortOrder)
values (1, 'Education','<ul><li>Bachelor of Science in Marketing</li><li>Object Oriented Analysis and Design</li><li>Test Driven Development</li></ul>',5)


insert into SectionContent (ContactId, Title, Content, SortOrder)
values (4, 'Summary','Summary goes here',1)
insert into SectionContent (ContactId, Title, Content, SortOrder)
values (4, 'Skills','Skills goe here',2)



select * from Contacts
select * from SectionContent
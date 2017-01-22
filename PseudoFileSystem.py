
class File():
    
    def __init__(self, parent, name, lines):
        '''lines is a list of strings'''
        self._parent = parent
        self._lines = lines
        self._name = name

    def get_parent(self):
        return self._parent

    def get_title(self):
        return self._name

    def __str__(self):
        for line in self._lines:
            print(line)
        return '*end of file*'

    def read(self):
        return self._lines
    

class Folder():

    def __init__(self, title, parent):
        self._items = {}
        self._title = title
        self._parent = parent

    def get_title(self):
        return self._title

    def get_parent(self):
        return self._parent

    def create_folder(self, title):
        new_folder = Folder(title, self._title)
        self._items[title] = new_folder

    def create_file(self, name, lines):
        new_file = File(self._title, name, lines)
        self._items[name] = new_file

    def delete_item(self, title):
        del self._items[title]

    def return_all_items(self):
        if self._items == {}:
            return False
        else:
            return self._items

    def return_item(self, title):
        if self._items == {}:
            return False
        else:
            return self._items[title]
    
    def __str__(self):
        items = []
        for item in self._items:
            items.append(item)
        
        return ''.join(items)
        

class FileSystem(Folder):

    def __init__(self):
        Folder.__init__(self, 'user', 'root')

    def create_folders(self, titles):
        for i in range(len(titles)):
            self.create_folder(titles[i])

    def get_folder(self, title):
        if title in self._items:
            return self._items[title]

    def mapper(self, folder):
        temp_list = []
        new_list = []
        temp_list.append(folder.get_title())
        if not(folder.return_all_items() == False):
            for key in folder.return_all_items():
                if (type(folder.return_all_items()[key]) is Folder):
                    new_folder = folder.return_all_items()[key]
                    new_list += self.mapper(new_folder)
                else:
                    new_list.append([folder.return_all_items()[key].get_title()])

        if not new_list == []:
            temp_list.append(new_list)
        return temp_list






    #def __init__(self):
        #self._directory = Folder('user', 'root')
        #self._items = self._directory.return_all_items()
        #self._title = 'root'
        #self._parent = 'system'
        #self._map = []

    #def mapper(self, folder):
        ##recursive
        
        #temp_list = []
        #temp_list.append(self.get_title())
        #elements = self.return_all_items()
        #print(elements)

        #return temp_list

    #def show_map(self):
        
        #master_list = []
        
        #pass

    #def create_folders(self, titles):
        #'''titles is list of str'''
        #for i in range(len(titles)):
            #self._directory.create_folder(titles[i])

    #def get_folder(self, title):
        #return self._directory.return_item(title)

    #def return_folders(self):
        #return self._directory

    #def __str__(self):
        #return_list = []
        #folders = self._directory.return_all_items()
        #if folders == False:
            #return ''
        #else:
            #for folder_name in folders:
                #return_list.append(folder_name)
            #return ' '.join(return_list)


class terminal():

    def __init__(self, file_system):
        self._input = ''
        self._file_system = file_system

    def run_ls(self):
        items = self._file_system.return_all_items()

        l = ['**Empty Directory**']
        if not (items == False):
            l = []
            for t in items:
                l.append(t)
        for element in l:
            print(element)

    def run_pwd(self):
        title = self._file_system.get_title()
        print(title)


def run_terminal():
    exit = False
    
    fsys = FileSystem()
    fsys.create_folders(['games', 'music', 'docs'])
    games = fsys.get_folder('games')
    games.create_folder('pacman')
    games.create_file('pacman.txt', ['abc', 'def', 'ghi'])

    t = terminal(fsys)

    while exit == False:
        user_input = input('\nenter line bruh\n')
        if user_input == '':
            exit = True
        elif user_input == 'ls':
            t.run_ls()
        elif user_input == 'pwd':
            t.run_pwd()
            
                

run_terminal()


#print(fsys.mapper(fsys))

#t = terminal(fsys)
#input1 = input('>')
#if input1 == 'ls':
    #t.run_ls()
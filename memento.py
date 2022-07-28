# MEMENTO PATTERN
#
#  _____________________________                               ______________________                                     _______________________________
# |        	Originator      	|                             |        Memento       |									 |           CareTaker           |
# |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|                             |~~~~~~~~~~~~~~~~~~~~~~|									 |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|
# |	state                   	|                             | state                |									 | mementos                      |
# |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~| --------(save state)------->|~~~~~~~~~~~~~~~~~~~~~~| -------(contains mementos)------<>|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|
# | save_as_memento() -> memento|                             | get_state() -> state |                                   | set_memento(state)            |
# | get_as_memento(memento) 	|                             |______________________|                                   | get_memento(index) -> Memento |
# |_____________________________|                                                                                        |_______________________________|
#
# Usage: easily undo and redo changes, save states of objects
# 
# Why not simply Originator <-> CareTaker
# * Memento can save only specific states of Originator
# * Multiple mementos for multiple states

# Maintaining the state of originator
# This memento contains saved text
class MementoText:
	def __init__(self, article):
		self.article = article

	def get_article(self):
		return self.article

# Keeping track of multiple mementos
class CareTaker:
	def __init__(self):
		self.mementos = []

	def set_memento(self, article):
		self.mementos.append(MementoText(article))

	def get_memento(self, index):
		return self.mementos[index]

	# remove the last element of 'mementos' 'cut_length' times
	# for example 'cut_length = 2 -> memento[-2], memento[-1] are removed'
	def delete_next(self, cut_length):
		self.mementos = self.mementos[:-cut_length]				

# Object, state of which we want to save
class Article:
	def __init__(self, article):
		self.article = article

	def __str__(self):
		return self.article

	def save_as_memento(self):
		return MementoText(self.article)

	def get_from_memento(self, memento):
		self.article = memento.get_article()


#working example

if __name__ == "__main__":
	article = Article("Apple a day keeps doctor away!")
	care_taker = CareTaker()
	care_taker.set_memento(article.article)

	while True:
		string = input()

		if string == "undo":
			memento = care_taker.get_memento(-2)
			article.get_from_memento(memento)
			print("Back to \"" + str(article) + "\"")

			# Clearing all mementos after current
			care_taker.delete_next(1)
		else:
			article.article = string
			care_taker.set_memento(string)
			print("Set to \"" + str(article) + "\"")
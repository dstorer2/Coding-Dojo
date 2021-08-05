from flask_app.config.mysqlconnection import connectToMySQL
from flask import flash

# create a class that includes the same attributes as the table you are modelling in the __init__ function

#class Class:
#   def __init__(self, data):
#       self.id = data['id']
#       ...
#       self.updated_at = data['updated_at']

#   add class and static methods here. For example:

#   @staticmethod
    # def validate_*class name*(*class name*):
        # is_valid = True # we assume this is true
        # if len(*class name*['name']) < 1:
            # flash("Please enter a name for your dojo.")
            # is_valid = False
        # return is_valid

#    @classmethod
#        def save( cls, data):
#        query = "INSERT INTO *table name* ( *column names* ) VALUES ( %( *column values* )s, now(), now() )"
#        return connectToMySQL( '*schema name*' ).query_db(query, data)
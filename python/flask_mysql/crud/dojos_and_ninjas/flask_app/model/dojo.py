from flask_app.config.mysqlconnection import connectToMySQL
from flask_app.model.ninja import Ninja


class Dojo:
    def __init__(self, data):
        self.id = data['id']
        self.name = data['name']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']
        self.ninjas = []
    # Now we use class methods to query our database
    @classmethod
    def get_all(cls):
        query = "SELECT * FROM dojos;"
        # make sure to call the connectToMySQL function with the schema you are targeting.
        results = connectToMySQL('dojos_and_ninjas_schema').query_db(query)
        # Create an empty list to append our instances of friends
        dojos = []
        # Iterate over the db results and create instances of friends with cls.
        for dojo in results:
            dojos.append( cls(dojo) )
        return dojos

# =====================================================
# SHOW DOJO WITH NINJAS
# =====================================================

    @classmethod
    def get_ninjas_in_dojo(cls, data):
        print(data)
        query = "SELECT ninjas.dojo_id, ninjas.first_name, ninjas.last_name, ninjas.age FROM dojos LEFT JOIN ninjas ON dojos.id = ninjas.dojo_id WHERE dojos.id = %(dojo_id)s;"
        results = connectToMySQL('dojos_and_ninjas_schema').query_db( query, data )
        # print("In classmethod")
        # print(results)
        # dojo_ninjas = []
        # print(dojo_ninjas)
        # for ninja_info in results:
        #     ninja_data = {
        #         # "id": ninja_info['ninjas.id'],
        #         "first_name": ninja_info['first_name'],
        #         "last_name": ninja_info['last_name'],
        #         "age": ninja_info['age'],
        #         # "created_at": ninja_info['ninjas.created_at'],
        #         # "updated_at": ninja_info['ninjas.updated_at'],
        #         "dojo_id": ninja_info['ninjas.dojo_id']
        #     }
        #     print(dojo_ninjas)
        #     dojo_ninjas.append( ninja_data )
        return results

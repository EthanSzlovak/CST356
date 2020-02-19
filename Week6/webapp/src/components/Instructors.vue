<template>
  <div> 
    <html>
        <head>
        <link rel="stylesheet" type="text/css" href='style.css'>
    
        
        </head>
        <body>
        
            <h1 class="tablehead">Instructors</h1>
            <table>
            <thead>
                <tr>
                    <th>Last Name</th>
                    <th>First Name</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="student in students" v-bind:key="student">
                    <td>{{ student.lastName }}</td>
                    <td>{{ student.firstName }}</td>
                </tr>
            </tbody>
          </table>
        </body>
    </html>
  </div>
</template>

<script>
 export default {
        name: 'Instructors',
        mounted() {
            this.students = getStudents();
        },
        data () {
            return {
                students: []
            }
        }
    }
    function getStudents() {
        return JSON.parse(students);
    }
    var students = '[{"firstName": "Jim", "lastName": "Jones"}, {"firstName": "Marshall", "lastName": "Applewhite"}]';
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>

<template>
  <div> 
    <html>
    <head>
        <link rel = "stylesheet" type = "text/css" href = "style.css">
    </head>
    <body>    
        <h2 class='section-heading'>Students</h2>
        <table>
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Email</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="student in students" v-bind:key="student">
                    <td>{{ student.Name }}</td>
                    <td>{{ student.Email }}</td>
                </tr>
            </tbody>
        </table>
    </body>
	
    </html>

  </div>
</template>

<script>
 export default {
        name: 'Students',
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
    var students = '[{"Name": "Tom Smith", "Email": "Tom.Jones@gmail.com"}, {"Name": "Mary Jones", "Email": "Mary.Jones@gmail.com"}]';
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>

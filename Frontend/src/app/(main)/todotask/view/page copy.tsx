"use client";
import { Button } from "@/components/ui/button";
import { fetchTasks } from "@/lib/api/queries/todotasks/fetch";
import { useState } from "react";
import useSWR from "swr";
import { DataTable } from "../../../common/ui/Datatable/Datatable";
import { columns } from "./components/Column";

export default function page() {
  const { data: tasks, error, mutate } = useSWR("/tasks", fetchTasks);
  const [taskTitle, setTaskTitle] = useState("");
  console.log(tasks);

  // if (error) return <p className="text-red-500">Failed to load tasks.</p>;
  // if (!tasks) return <p>Loading...</p>;

  //   const handleCreateTask = async () => {
  //     if (!taskTitle) return;
  //     await createTask({ title: taskTitle, description: "New task" });
  //     mutate(); // Refresh the task list
  //     setTaskTitle("");
  //   };
  const user = Array.from({ length: 11 }, (_, i) => ({ id: `user-${i + 1}` }));
  return (
    <div className="p-5">
      <DataTable columns={columns} data={user} isLoading={false} />
    </div>
  );
}

"use client";
import { useState } from "react";
import { DataTable } from "../../../common/ui/Datatable/Datatable";
import { columns } from "./components/Column";
import useSWR from "swr";
import { fetchTasks } from "@/lib/api/queries/todotasks/fetch";
import { Button } from "@/components/ui/button";

export default function page() {
  const {
    data: tasks,
    error,
    mutate,
    isLoading,
  } = useSWR("/tasks", fetchTasks);
  const [taskTitle, setTaskTitle] = useState("");
  const user = Array.from({ length: 11 }, (_, i) => ({
    id: `user-${i + 1}`,
    name: "abel",
  }));
  const [filterValues, setFilterValues] = useState<{ [key: string]: string }>({
    name: "",
    description: "",
  });
  const filteredUser = tasks?.filter((item: any) => {
    return (
      (filterValues.name
        ? item.name.toLowerCase().includes(filterValues.name.toLowerCase())
        : true) &&
      (filterValues.description
        ? item.description
            .toLowerCase()
            .includes(filterValues.aircraftTypeCode.toLowerCase())
        : true)
    );
  });
  const handleFilterChange = (column: string, value: string) => {
    setFilterValues((prev) => ({
      ...prev,
      [column]: value,
    }));
  };
  return (
    <div className="p-5">
      <div className="mb-4 space-y-2">
        {/* Filter for id */}
        <input
          type="text"
          placeholder="Filter by ID"
          value={filterValues.id}
          onChange={(e) => handleFilterChange("id", e.target.value)}
          className="border p-2"
        />

        <input
          type="text"
          placeholder="Filter by Name"
          value={filterValues.aircraftTypeCode}
          onChange={(e) =>
            handleFilterChange("aircraftTypeCode", e.target.value)
          }
          className="border p-2"
        />
      </div>
      <Button>Test</Button>
      <DataTable
        columns={columns}
        data={filteredUser || []}
        isLoading={isLoading}
      />
    </div>
  );
}
